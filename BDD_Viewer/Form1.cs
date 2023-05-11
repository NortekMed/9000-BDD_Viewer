using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using FirebirdSql.Data.FirebirdClient;
using static System.Windows.Forms.AxHost;

namespace BDD_Viewer
{
    public partial class Form1 : Form
    {
        static CultureInfo ci;

        static List<DB> DB_List = new List<DB>();

        public static DB current_DB = new DB();

        public static DataTable current_DataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();

            progressBar_ExportCSV.Value= 0;

            //Read Config Liste BDD
            StreamReader conf = new StreamReader("Liste_BDD.txt");

            List<string> arguments = new List<string>();
            string line = "";
            try
            {
                // pour s'assurer d'avoir un '.' pour séparateur décimal
                Form1.ci = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
                Form1.ci.NumberFormat.NumberDecimalSeparator = ".";
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;


                Console.WriteLine("Read config file conf.txt");

                while ((line = conf.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    if ((line.Length != 0) && !line.Contains("//"))
                        arguments.Add(line);
                }

                conf.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source + " : " + ex.Message);
            }

            string[] argTab = arguments.ToArray();

            DB Current_DB = new DB();

            for (int i = 0; i < argTab.Length; i++)
            {
                if (argTab[i].Contains("="))
                {
                    string arg = argTab[i].Split('=')[0];
                    string value = argTab[i].Split('=')[1];

                    switch (arg.ToUpper())
                    {
                        case "NAME":
                            if (Current_DB.Name == "")
                            {
                                Current_DB.Name = value;
                            }
                            else
                            {
                                DB_List.Add(Current_DB);
                                Current_DB = new DB();
                                Current_DB.Name = value;
                            }
                            break;

                        case "DB_PATH":
                            Current_DB.Path = value;
                            break;


                        default:
                            break;
                    }
                }
            }

            if (Current_DB.Name != "")
            {
                DB_List.Add(Current_DB);
            }

            for(int i=0; i< DB_List.Count; i++)
            {
                DB_List[i].set_FbConnection();
                listBox_Databases.Items.Add(DB_List[i].Name);
            }

            //Init DateTimePicker Date
            dateTimePicker_From.Value = DateTime.UtcNow.AddMonths(-6);
            dateTimePicker_To.Value = DateTime.UtcNow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox_Databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_Databases.SelectedIndex;
            current_DB = DB_List[index];

            label_Path_Current_DB.Text = current_DB.Path;

            //Nettoie les listBox inférieures
            listBox_Columns.Items.Clear();
            listBox_Tables.Items.Clear();

            //Ouvre la connexion à la BDD
            current_DB.databaseconnnection.Open();

            DataSet ds = new DataSet();
            FbDataAdapter dataAdapter = new FbDataAdapter("SELECT a.RDB$RELATION_NAME" +
                                                         " FROM RDB$RELATIONS a" +
                                                         " WHERE COALESCE(RDB$SYSTEM_FLAG, 0) = 0 AND RDB$RELATION_TYPE = 0", current_DB.databaseconnnection);

            dataAdapter.Fill(ds);
            DataTable myDataTable = ds.Tables[0];

            //Ferme la connextion à la BDD
            current_DB.databaseconnnection.Close();

            foreach (DataRow dRow in myDataTable.Rows)
            {
                string Table_Name = dRow[0].ToString().Replace(" ","");
                listBox_Tables.Items.Add(Table_Name);
            }
        }

        private void listBox_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nettoie les listBox inférieures
            listBox_Columns.Items.Clear();

            //Ouvre la connexion à la BDD
            current_DB.databaseconnnection.Open();

            DataSet ds = new DataSet();
            FbDataAdapter dataAdapter = new FbDataAdapter("SELECT rdb$field_name" +
                                                         " FROM rdb$relation_fields" + 
                                                         " WHERE rdb$relation_name = '" + listBox_Tables.SelectedItem + "'; ", current_DB.databaseconnnection);

            dataAdapter.Fill(ds);
            DataTable myDataTable = ds.Tables[0];

            //Ferme la connextion à la BDD
            current_DB.databaseconnnection.Close();

            foreach (DataRow dRow in myDataTable.Rows)
            {
                string Table_Name = dRow[0].ToString().Replace(" ", "");
                listBox_Columns.Items.Add(Table_Name);
            }

        }

        private void timer_Interface_Tick(object sender, EventArgs e)
        {
            //Activation du bouton téléchargement données
            if(listBox_Columns.SelectedItems.Count > 0)
            {
                button_GetData.Enabled= true;
            }
            else { button_GetData.Enabled= false; }

            //Activation du bouton de téléchargement CSV
            if(current_DataTable.DefaultView.Count > 0)
            {
                button_Export_to_CSV.Enabled= true;
            }
            else { button_Export_to_CSV.Enabled= false; }

            //Activation du bouton FastChart
            if (listBox_Columns.SelectedItems.Count > 0)
            {
                button_FastChart.Enabled = true;
            }
            else { button_FastChart.Enabled = false; }

        }

        private void button_GetData_Click(object sender, EventArgs e)
        {
            button_Export_to_CSV.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            //Ouvre la connexion à la BDD
            current_DB.databaseconnnection.Open();
            DataSet ds = new DataSet();

            string cmd = "SELECT a.TIME_REC, ";

            foreach(var Item in listBox_Columns.SelectedItems)
            {
                if (Item.ToString() != "TIME_REC")
                {
                    cmd += "a." + Item.ToString() + ", ";
                }
            }

            //Retire la dernière virgule
            cmd = cmd.Remove(cmd.Length - 2);

            string timestampsrequest = " WHERE a.TIME_REC>='" + dateTimePicker_From.Value.ToString("dd.MM.yyyy , 00:00:00") + "' and a.TIME_REC<='" + dateTimePicker_To.Value.ToString("dd.MM.yyyy , 23:59:59") + "'";

            string source = " FROM " + listBox_Tables.SelectedItem.ToString() + " a";

            string order_by = " order by a.TIME_REC";

            string full_cmd = "";

            if (listBox_Columns.Items.Contains(textBox_Xaxis.Text))
            {
                full_cmd = cmd.Replace("TIME_REC", textBox_Xaxis.Text) + source + timestampsrequest.Replace("TIME_REC", textBox_Xaxis.Text) + order_by.Replace("TIME_REC", textBox_Xaxis.Text);
            }
            else
            {
                full_cmd = cmd.Replace("a.TIME_REC, ", "") + source;
            }

            FbDataAdapter dataAdapter = new FbDataAdapter(full_cmd, current_DB.databaseconnnection);

            dataAdapter.Fill(ds);
            current_DataTable = ds.Tables[0];

            //Actualise l'affichage
            label_number_lines.Text = current_DataTable.DefaultView.Count.ToString() + " Lignes";

            //Ferme la connextion à la BDD
            current_DB.databaseconnnection.Close();

            if(current_DataTable.DefaultView.Count != 0)
            {
                button_Export_to_CSV.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void button_Export_to_CSV_Click(object sender, EventArgs e)
        {
            button_Export_to_CSV.Enabled= false;
            Cursor.Current = Cursors.WaitCursor;

            string exe_path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = exe_path.Remove(exe_path.LastIndexOf("\\")) + "\\CSV\\";

            string file_name = listBox_Databases.SelectedItem.ToString() + "-" + listBox_Tables.SelectedItem.ToString() + "-" + "FROM_" + dateTimePicker_From.Value.ToString("yyyy-MM-dd") + "-" + "TO_" + dateTimePicker_To.Value.ToString("yyyy-MM-dd");

            exportToCSV(path, file_name,ref current_DataTable);

            button_Export_to_CSV.Enabled= true;
            Cursor.Current = Cursors.Default;
        }

        public void exportToCSV(string path, string filename,ref DataTable data)
        {
            string header = "";
            List<List<string>> lst_data = new List<List<string>>();

            foreach (var col_name in data.Columns)
            {
                header += col_name.ToString() + ";";
                lst_data.Add(new List<string>());
            }

            StreamWriter sw = new StreamWriter(path+filename+".txt", false);

            sw.WriteLine(header);

            string new_line;

            progressBar_ExportCSV.Maximum = data.Rows.Count;

            for (int row =0; row < data.Rows.Count; row++)
            {
                progressBar_ExportCSV.Value = row;

                new_line = "";
                DataRow row_data = data.Rows[row];

                for(int col=0; col < data.Columns.Count; col++)
                {
                    new_line += row_data[col] + ";";
                }

                sw.WriteLine(new_line);
            }

            sw.Close();

        }

        private void button_Script_Click(object sender, EventArgs e)
        {
            string script_path = String.Empty;
            OpenFileDialog fileDialog= new OpenFileDialog();
            string exe_path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            fileDialog.InitialDirectory = exe_path.Remove(exe_path.LastIndexOf("\\"));
            fileDialog.Filter = "Fichier Text (*.txt)|*.txt|Tout (*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            string filePath = String.Empty;

            string line = String.Empty;
            List<string> arguments = new List<string>();

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox_Databases.Items.Clear();
                DB_List.Clear();

                //Get the path of specified file
                filePath = fileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = fileDialog.OpenFile();

                //Read the Script
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        if ((line.Length != 0) && !line.Contains("//"))
                            arguments.Add(line);
                    }

                    reader.Close();
                }

                string[] argTab = arguments.ToArray();

                DB Current_DB = new DB();

                for (int i = 0; i < argTab.Length; i++)
                {
                    if (argTab[i].Contains("="))
                    {
                        string arg = argTab[i].Split('=')[0];
                        string value = argTab[i].Split('=')[1];

                        switch (arg.ToUpper())
                        {
                            case "NAME":
                                if (Current_DB.Name == "")
                                {
                                    Current_DB.Name = value;
                                }
                                else
                                {
                                    DB_List.Add(Current_DB);
                                    Current_DB = new DB();
                                    Current_DB.Name = value;
                                }
                                break;

                            case "DB_PATH":
                                Current_DB.Path = value;
                                break;


                            case "TABLE":
                                Current_DB.Table = value;
                                break;

                            case "COLUMNS":
                                Current_DB.Columns = value;
                                break;

                            default:
                                break;
                        }
                    }
                }

                if (Current_DB.Name != "")
                {
                    DB_List.Add(Current_DB);
                }

                for (int i = 0; i < DB_List.Count; i++)
                {
                    DB_List[i].set_FbConnection();
                    listBox_Databases.Items.Add(DB_List[i].Name);
                }

                for (int i=0; i< DB_List.Count; i++)
                {
                    listBox_Databases.SelectedItem = DB_List[i].Name;
                    listBox_Tables.SelectedItem= DB_List[i].Table;
                    string[] items = DB_List[i].Columns.Split(';');
                    for(int j = 0; j < items.Count(); j++) {
                        listBox_Columns.SetSelected(listBox_Columns.FindString(items[j]), true);
                    }

                    button_GetData_Click(null,null);
                    button_Export_to_CSV_Click(null,null);
                }
            }
        }

        private void button_FastChart_Click(object sender, EventArgs e)
        {
            // Téléchargement des données
            button_GetData_Click(null,null);

            if(current_DataTable.DefaultView.Count != 0)
            {
                string chart_name = listBox_Databases.SelectedItem.ToString() + "-" + listBox_Tables.SelectedItem.ToString() + "-" + "FROM_" + dateTimePicker_From.Value.ToString("yyyy-MM-dd") + "-" + "TO_" + dateTimePicker_To.Value.ToString("yyyy-MM-dd");

                Form_Chart test = new Form_Chart(current_DataTable, chart_name, textBox_Xaxis.Text);
                test.Show();
            }
        }
    }

    public class DB
    {
        public string Name;
        public string Path;
        public string Table;
        public string Columns;

        public FbConnection databaseconnnection = null;

        public DB()
        {
            Name = "";
            Path = "";
        }

        public void set_FbConnection()
        {
            string s_connection = "User=SYSDBA;" +
                    "Password=masterkey;" +
                    "Database=" + this.Path + ";" +
                    "DataSource=localhost;" +
                    "Port=3050;" +
                    "Dialect=3;" +
                    "Charset=ISO8859_1;";

            this.databaseconnnection= new FbConnection(s_connection);
        }
    }
}
