namespace BDD_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_SearchBar = new System.Windows.Forms.TextBox();
            this.button_Delete_DB = new System.Windows.Forms.Button();
            this.listBox_Databases = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_Tables = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_Columns = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Path_Current_DB = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.button_GetData = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_Open_CSV_Folder = new System.Windows.Forms.Button();
            this.button_Script = new System.Windows.Forms.Button();
            this.progressBar_ExportCSV = new System.Windows.Forms.ProgressBar();
            this.button_Export_to_CSV = new System.Windows.Forms.Button();
            this.label_number_lines = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_Interface = new System.Windows.Forms.Timer(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_FastChart = new System.Windows.Forms.Button();
            this.textBox_Xaxis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button_24H = new System.Windows.Forms.Button();
            this.button_7Days = new System.Windows.Forms.Button();
            this.button_6Months = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_Browse_DB_Path = new System.Windows.Forms.Button();
            this.textBox_New_DB_Path = new System.Windows.Forms.TextBox();
            this.textBox_New_DB_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Add_DB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_SearchBar);
            this.groupBox1.Controls.Add(this.button_Delete_DB);
            this.groupBox1.Controls.Add(this.listBox_Databases);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Séléction BDD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Filtrer :";
            // 
            // textBox_SearchBar
            // 
            this.textBox_SearchBar.Location = new System.Drawing.Point(47, 17);
            this.textBox_SearchBar.Name = "textBox_SearchBar";
            this.textBox_SearchBar.Size = new System.Drawing.Size(127, 20);
            this.textBox_SearchBar.TabIndex = 2;
            this.textBox_SearchBar.TextChanged += new System.EventHandler(this.textBox_SearchBar_TextChanged);
            // 
            // button_Delete_DB
            // 
            this.button_Delete_DB.Location = new System.Drawing.Point(20, 412);
            this.button_Delete_DB.Name = "button_Delete_DB";
            this.button_Delete_DB.Size = new System.Drawing.Size(139, 23);
            this.button_Delete_DB.TabIndex = 1;
            this.button_Delete_DB.Text = "Effacer BDD séléctionnée";
            this.button_Delete_DB.UseVisualStyleBackColor = true;
            this.button_Delete_DB.Click += new System.EventHandler(this.button_Delete_DB_Click);
            // 
            // listBox_Databases
            // 
            this.listBox_Databases.FormattingEnabled = true;
            this.listBox_Databases.Location = new System.Drawing.Point(6, 42);
            this.listBox_Databases.Name = "listBox_Databases";
            this.listBox_Databases.Size = new System.Drawing.Size(168, 368);
            this.listBox_Databases.TabIndex = 0;
            this.listBox_Databases.SelectedIndexChanged += new System.EventHandler(this.listBox_Databases_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_Tables);
            this.groupBox2.Location = new System.Drawing.Point(196, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 439);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Séléction Table";
            // 
            // listBox_Tables
            // 
            this.listBox_Tables.FormattingEnabled = true;
            this.listBox_Tables.Location = new System.Drawing.Point(6, 16);
            this.listBox_Tables.Name = "listBox_Tables";
            this.listBox_Tables.Size = new System.Drawing.Size(136, 420);
            this.listBox_Tables.TabIndex = 0;
            this.listBox_Tables.SelectedIndexChanged += new System.EventHandler(this.listBox_Tables_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_Columns);
            this.groupBox3.Location = new System.Drawing.Point(350, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 439);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Séléction Colonne";
            // 
            // listBox_Columns
            // 
            this.listBox_Columns.FormattingEnabled = true;
            this.listBox_Columns.Location = new System.Drawing.Point(6, 16);
            this.listBox_Columns.Name = "listBox_Columns";
            this.listBox_Columns.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_Columns.Size = new System.Drawing.Size(136, 420);
            this.listBox_Columns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chemin :";
            // 
            // label_Path_Current_DB
            // 
            this.label_Path_Current_DB.AutoSize = true;
            this.label_Path_Current_DB.Location = new System.Drawing.Point(64, 456);
            this.label_Path_Current_DB.Name = "label_Path_Current_DB";
            this.label_Path_Current_DB.Size = new System.Drawing.Size(0, 13);
            this.label_Path_Current_DB.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker_From);
            this.groupBox4.Location = new System.Drawing.Point(504, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 47);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DU    (UTC)";
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(7, 18);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker_From.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker_To);
            this.groupBox5.Location = new System.Drawing.Point(504, 122);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(260, 48);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AU    (UTC)";
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(7, 18);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker_To.TabIndex = 1;
            // 
            // button_GetData
            // 
            this.button_GetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetData.Location = new System.Drawing.Point(7, 19);
            this.button_GetData.Name = "button_GetData";
            this.button_GetData.Size = new System.Drawing.Size(247, 50);
            this.button_GetData.TabIndex = 7;
            this.button_GetData.Text = "Charger les Données";
            this.button_GetData.UseVisualStyleBackColor = true;
            this.button_GetData.Click += new System.EventHandler(this.button_GetData_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_Open_CSV_Folder);
            this.groupBox6.Controls.Add(this.button_Script);
            this.groupBox6.Controls.Add(this.progressBar_ExportCSV);
            this.groupBox6.Controls.Add(this.button_Export_to_CSV);
            this.groupBox6.Controls.Add(this.label_number_lines);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.button_GetData);
            this.groupBox6.Location = new System.Drawing.Point(504, 176);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 273);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // button_Open_CSV_Folder
            // 
            this.button_Open_CSV_Folder.Location = new System.Drawing.Point(6, 189);
            this.button_Open_CSV_Folder.Name = "button_Open_CSV_Folder";
            this.button_Open_CSV_Folder.Size = new System.Drawing.Size(248, 23);
            this.button_Open_CSV_Folder.TabIndex = 13;
            this.button_Open_CSV_Folder.Text = "Ouvrir le dossier des CSV";
            this.button_Open_CSV_Folder.UseVisualStyleBackColor = true;
            this.button_Open_CSV_Folder.Click += new System.EventHandler(this.button_Open_CSV_Folder_Click);
            // 
            // button_Script
            // 
            this.button_Script.Location = new System.Drawing.Point(6, 246);
            this.button_Script.Name = "button_Script";
            this.button_Script.Size = new System.Drawing.Size(248, 23);
            this.button_Script.TabIndex = 12;
            this.button_Script.Text = "Exécuter un Script";
            this.button_Script.UseVisualStyleBackColor = true;
            this.button_Script.Click += new System.EventHandler(this.button_Script_Click);
            // 
            // progressBar_ExportCSV
            // 
            this.progressBar_ExportCSV.Location = new System.Drawing.Point(9, 160);
            this.progressBar_ExportCSV.Name = "progressBar_ExportCSV";
            this.progressBar_ExportCSV.Size = new System.Drawing.Size(245, 23);
            this.progressBar_ExportCSV.TabIndex = 11;
            this.progressBar_ExportCSV.Value = 65;
            // 
            // button_Export_to_CSV
            // 
            this.button_Export_to_CSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Export_to_CSV.Location = new System.Drawing.Point(6, 119);
            this.button_Export_to_CSV.Name = "button_Export_to_CSV";
            this.button_Export_to_CSV.Size = new System.Drawing.Size(248, 38);
            this.button_Export_to_CSV.TabIndex = 10;
            this.button_Export_to_CSV.Text = "Exporter en CSV";
            this.button_Export_to_CSV.UseVisualStyleBackColor = true;
            this.button_Export_to_CSV.Click += new System.EventHandler(this.button_Export_to_CSV_Click);
            // 
            // label_number_lines
            // 
            this.label_number_lines.AutoSize = true;
            this.label_number_lines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number_lines.Location = new System.Drawing.Point(80, 72);
            this.label_number_lines.Name = "label_number_lines";
            this.label_number_lines.Size = new System.Drawing.Size(51, 13);
            this.label_number_lines.TabIndex = 9;
            this.label_number_lines.Text = "0 lignes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "En mémoire :";
            // 
            // timer_Interface
            // 
            this.timer_Interface.Enabled = true;
            this.timer_Interface.Tick += new System.EventHandler(this.timer_Interface_Tick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_FastChart);
            this.groupBox7.Controls.Add(this.textBox_Xaxis);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(504, 459);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(260, 78);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Graphiques";
            // 
            // button_FastChart
            // 
            this.button_FastChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FastChart.Location = new System.Drawing.Point(10, 48);
            this.button_FastChart.Name = "button_FastChart";
            this.button_FastChart.Size = new System.Drawing.Size(243, 23);
            this.button_FastChart.TabIndex = 2;
            this.button_FastChart.Text = "Tracé rapide";
            this.button_FastChart.UseVisualStyleBackColor = true;
            this.button_FastChart.Click += new System.EventHandler(this.button_FastChart_Click);
            // 
            // textBox_Xaxis
            // 
            this.textBox_Xaxis.Location = new System.Drawing.Point(54, 20);
            this.textBox_Xaxis.Name = "textBox_Xaxis";
            this.textBox_Xaxis.Size = new System.Drawing.Size(199, 20);
            this.textBox_Xaxis.TabIndex = 1;
            this.textBox_Xaxis.Text = "TIME_REC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Axe X :";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button_24H);
            this.groupBox8.Controls.Add(this.button_7Days);
            this.groupBox8.Controls.Add(this.button_6Months);
            this.groupBox8.Location = new System.Drawing.Point(504, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(260, 50);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Plage de temps";
            // 
            // button_24H
            // 
            this.button_24H.Location = new System.Drawing.Point(5, 19);
            this.button_24H.Name = "button_24H";
            this.button_24H.Size = new System.Drawing.Size(41, 23);
            this.button_24H.TabIndex = 0;
            this.button_24H.Text = "24H";
            this.button_24H.UseVisualStyleBackColor = true;
            this.button_24H.Click += new System.EventHandler(this.button_24H_Click);
            // 
            // button_7Days
            // 
            this.button_7Days.Location = new System.Drawing.Point(98, 19);
            this.button_7Days.Name = "button_7Days";
            this.button_7Days.Size = new System.Drawing.Size(51, 23);
            this.button_7Days.TabIndex = 1;
            this.button_7Days.Text = "7 Jours";
            this.button_7Days.UseVisualStyleBackColor = true;
            this.button_7Days.Click += new System.EventHandler(this.button_7Days_Click);
            // 
            // button_6Months
            // 
            this.button_6Months.Location = new System.Drawing.Point(208, 19);
            this.button_6Months.Name = "button_6Months";
            this.button_6Months.Size = new System.Drawing.Size(46, 23);
            this.button_6Months.TabIndex = 2;
            this.button_6Months.Text = "6 Mois";
            this.button_6Months.UseVisualStyleBackColor = true;
            this.button_6Months.Click += new System.EventHandler(this.button_6Months_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button_Browse_DB_Path);
            this.groupBox9.Controls.Add(this.textBox_New_DB_Path);
            this.groupBox9.Controls.Add(this.textBox_New_DB_Name);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.button_Add_DB);
            this.groupBox9.Location = new System.Drawing.Point(10, 474);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(342, 108);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ajouter BDD";
            // 
            // button_Browse_DB_Path
            // 
            this.button_Browse_DB_Path.Location = new System.Drawing.Point(284, 46);
            this.button_Browse_DB_Path.Name = "button_Browse_DB_Path";
            this.button_Browse_DB_Path.Size = new System.Drawing.Size(50, 23);
            this.button_Browse_DB_Path.TabIndex = 5;
            this.button_Browse_DB_Path.Text = "Ouvrir";
            this.button_Browse_DB_Path.UseVisualStyleBackColor = true;
            this.button_Browse_DB_Path.Click += new System.EventHandler(this.button_Browse_DB_Path_Click);
            // 
            // textBox_New_DB_Path
            // 
            this.textBox_New_DB_Path.Location = new System.Drawing.Point(60, 48);
            this.textBox_New_DB_Path.Name = "textBox_New_DB_Path";
            this.textBox_New_DB_Path.Size = new System.Drawing.Size(218, 20);
            this.textBox_New_DB_Path.TabIndex = 4;
            this.textBox_New_DB_Path.TextChanged += new System.EventHandler(this.textBox_New_DB_Path_TextChanged);
            // 
            // textBox_New_DB_Name
            // 
            this.textBox_New_DB_Name.Location = new System.Drawing.Point(60, 22);
            this.textBox_New_DB_Name.Name = "textBox_New_DB_Name";
            this.textBox_New_DB_Name.Size = new System.Drawing.Size(218, 20);
            this.textBox_New_DB_Name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chemin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nom :";
            // 
            // button_Add_DB
            // 
            this.button_Add_DB.Location = new System.Drawing.Point(99, 77);
            this.button_Add_DB.Name = "button_Add_DB";
            this.button_Add_DB.Size = new System.Drawing.Size(75, 23);
            this.button_Add_DB.TabIndex = 0;
            this.button_Add_DB.Text = "Ajouter";
            this.button_Add_DB.UseVisualStyleBackColor = true;
            this.button_Add_DB.Click += new System.EventHandler(this.button_Add_DB_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 588);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label_Path_Current_DB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_Databases;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_Tables;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox_Columns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Path_Current_DB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.Button button_GetData;
        private System.Windows.Forms.Timer timer_Interface;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_number_lines;
        private System.Windows.Forms.Button button_Export_to_CSV;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.ProgressBar progressBar_ExportCSV;
        private System.Windows.Forms.Button button_Script;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_FastChart;
        private System.Windows.Forms.TextBox textBox_Xaxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button_6Months;
        private System.Windows.Forms.Button button_7Days;
        private System.Windows.Forms.Button button_24H;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button_Add_DB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_New_DB_Name;
        private System.Windows.Forms.TextBox textBox_New_DB_Path;
        private System.Windows.Forms.Button button_Browse_DB_Path;
        private System.Windows.Forms.Button button_Delete_DB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_SearchBar;
        private System.Windows.Forms.Button button_Open_CSV_Folder;
    }
}

