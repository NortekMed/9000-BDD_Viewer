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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Databases);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Séléction BDD";
            // 
            // listBox_Databases
            // 
            this.listBox_Databases.FormattingEnabled = true;
            this.listBox_Databases.Location = new System.Drawing.Point(6, 16);
            this.listBox_Databases.Name = "listBox_Databases";
            this.listBox_Databases.Size = new System.Drawing.Size(168, 394);
            this.listBox_Databases.TabIndex = 0;
            this.listBox_Databases.SelectedIndexChanged += new System.EventHandler(this.listBox_Databases_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_Tables);
            this.groupBox2.Location = new System.Drawing.Point(196, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 413);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Séléction Table";
            // 
            // listBox_Tables
            // 
            this.listBox_Tables.FormattingEnabled = true;
            this.listBox_Tables.Location = new System.Drawing.Point(6, 16);
            this.listBox_Tables.Name = "listBox_Tables";
            this.listBox_Tables.Size = new System.Drawing.Size(136, 394);
            this.listBox_Tables.TabIndex = 0;
            this.listBox_Tables.SelectedIndexChanged += new System.EventHandler(this.listBox_Tables_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_Columns);
            this.groupBox3.Location = new System.Drawing.Point(350, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 413);
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
            this.listBox_Columns.Size = new System.Drawing.Size(136, 394);
            this.listBox_Columns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chemin :";
            // 
            // label_Path_Current_DB
            // 
            this.label_Path_Current_DB.AutoSize = true;
            this.label_Path_Current_DB.Location = new System.Drawing.Point(67, 428);
            this.label_Path_Current_DB.Name = "label_Path_Current_DB";
            this.label_Path_Current_DB.Size = new System.Drawing.Size(0, 13);
            this.label_Path_Current_DB.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker_From);
            this.groupBox4.Location = new System.Drawing.Point(504, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 47);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DU";
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(7, 18);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker_From.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker_To);
            this.groupBox5.Location = new System.Drawing.Point(504, 65);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 48);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AU";
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(7, 18);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker_To.TabIndex = 1;
            // 
            // button_GetData
            // 
            this.button_GetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetData.Location = new System.Drawing.Point(7, 19);
            this.button_GetData.Name = "button_GetData";
            this.button_GetData.Size = new System.Drawing.Size(190, 50);
            this.button_GetData.TabIndex = 7;
            this.button_GetData.Text = "Charger les Données";
            this.button_GetData.UseVisualStyleBackColor = true;
            this.button_GetData.Click += new System.EventHandler(this.button_GetData_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_Script);
            this.groupBox6.Controls.Add(this.progressBar_ExportCSV);
            this.groupBox6.Controls.Add(this.button_Export_to_CSV);
            this.groupBox6.Controls.Add(this.label_number_lines);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.button_GetData);
            this.groupBox6.Location = new System.Drawing.Point(504, 119);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(203, 306);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // button_Script
            // 
            this.button_Script.Location = new System.Drawing.Point(6, 277);
            this.button_Script.Name = "button_Script";
            this.button_Script.Size = new System.Drawing.Size(191, 23);
            this.button_Script.TabIndex = 12;
            this.button_Script.Text = "Exécuter un Script";
            this.button_Script.UseVisualStyleBackColor = true;
            this.button_Script.Click += new System.EventHandler(this.button_Script_Click);
            // 
            // progressBar_ExportCSV
            // 
            this.progressBar_ExportCSV.Location = new System.Drawing.Point(9, 164);
            this.progressBar_ExportCSV.Name = "progressBar_ExportCSV";
            this.progressBar_ExportCSV.Size = new System.Drawing.Size(188, 23);
            this.progressBar_ExportCSV.TabIndex = 11;
            this.progressBar_ExportCSV.Value = 65;
            // 
            // button_Export_to_CSV
            // 
            this.button_Export_to_CSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Export_to_CSV.Location = new System.Drawing.Point(6, 119);
            this.button_Export_to_CSV.Name = "button_Export_to_CSV";
            this.button_Export_to_CSV.Size = new System.Drawing.Size(191, 38);
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
            this.groupBox7.Location = new System.Drawing.Point(714, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 78);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Graphiques";
            // 
            // button_FastChart
            // 
            this.button_FastChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FastChart.Location = new System.Drawing.Point(10, 48);
            this.button_FastChart.Name = "button_FastChart";
            this.button_FastChart.Size = new System.Drawing.Size(184, 23);
            this.button_FastChart.TabIndex = 2;
            this.button_FastChart.Text = "Tracé rapide";
            this.button_FastChart.UseVisualStyleBackColor = true;
            this.button_FastChart.Click += new System.EventHandler(this.button_FastChart_Click);
            // 
            // textBox_Xaxis
            // 
            this.textBox_Xaxis.Location = new System.Drawing.Point(54, 20);
            this.textBox_Xaxis.Name = "textBox_Xaxis";
            this.textBox_Xaxis.Size = new System.Drawing.Size(139, 20);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
    }
}

