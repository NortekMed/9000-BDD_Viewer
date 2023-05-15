using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using FirebirdSql.Data.FirebirdClient;
using ScottPlot;

namespace BDD_Viewer
{
    public partial class Form_Chart : Form
    {
        public DataTable data;

        public double[] xAxis_DateTime;

        public List<double[]> yAxis = new List<double[]>();

        public List<Thread> list_Thread = new List<Thread>();

        public Form_Chart(DataTable data, string Form_Title, string xAxis)
        {
            InitializeComponent();
            this.data = data;
            this.Text = Form_Title;
            this.label2.Text = xAxis;

            listBox_Y.Enabled = false;

            foreach (var col_name in data.Columns)
            {
                if (col_name.ToString() != xAxis)
                {
                    listBox_Y.Items.Add(col_name.ToString());
                }
            }

            //Create double[] DateTime
            xAxis_DateTime = new double[data.Rows.Count];

            //Create double[] pour Yaxis
            for (int i = 0; i < listBox_Y.Items.Count; i++)
            {
                yAxis.Add(new double[data.Rows.Count]);
            }

            //Thrad Création axe X
            list_Thread.Add(new Thread(() => this.createAxis_X(xAxis, ref xAxis_DateTime)));
            list_Thread[list_Thread.Count-1].Start();

            //Thread creation of axe Y
            for(int i=0; i < listBox_Y.Items.Count; i++)
            {
                int val = i;
                list_Thread.Add(new Thread(() => this.createAxis_Y(val, listBox_Y.Items[val].ToString())));
                list_Thread[list_Thread.Count-1].Start();
            }

        }
    
        
        public void createAxis_Y(int index, string col_name)
        {
            yAxis[index] = new double[data.Rows.Count];

            for(int i=0; i< data.Rows.Count; i++)
            {
                Double.TryParse(data.Rows[i][col_name].ToString(), out yAxis[index][i]);
            }
        }

        public void createAxis_X(string column_name, ref double[] X_axis)
        {
            X_axis = new double[data.Rows.Count];

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Double.TryParse(data.Rows[i][column_name].ToString(), out X_axis[i]);
                DateTime date = Convert.ToDateTime(data.Rows[i][column_name].ToString());
                X_axis[i] = date.ToOADate();
            }
        }

        private void Form_Chart_Load(object sender, EventArgs e)
        {

            foreach(Thread th in list_Thread)
            {
                th.Join();
            }
            
            //listBox_Y.SelectedIndex = 0;

            listBox_Y.Enabled = true;
        }

        private void listBox_Y_SelectedIndexChanged(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatter(xAxis_DateTime, yAxis[listBox_Y.SelectedIndex]);
            formsPlot1.Plot.XAxis.DateTimeFormat(true);
            formsPlot1.Update();
            formsPlot1.Refresh();
        }
    }
}
