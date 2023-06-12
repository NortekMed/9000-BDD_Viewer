using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using FirebirdSql.Data.FirebirdClient;
using ScottPlot;
using ScottPlot.Plottable;
using ScottPlot.Renderable;

namespace BDD_Viewer
{
    public partial class Form_Chart : Form
    {
        private ScottPlot.Plottable.ScatterPlot MyScatterPlot;
        private ScottPlot.Plottable.MarkerPlot HighlightedPoint;
        private int LastHighlightedIndex = -1;

        Tooltip last_tooltip = new Tooltip();

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
            if(listBox_Y.SelectedIndex != -1)
            {
                formsPlot1.Plot.Clear();

                MyScatterPlot = formsPlot1.Plot.AddScatter(xAxis_DateTime, yAxis[listBox_Y.SelectedIndex], label: listBox_Y.SelectedItem.ToString());
                formsPlot1.Plot.XAxis.DateTimeFormat(true);

                formsPlot1.Plot.Title(listBox_Y.SelectedItem.ToString() + " --- " + this.Text);
                formsPlot1.Plot.XLabel(this.label2.Text);
                formsPlot1.Plot.YLabel(listBox_Y.SelectedItem.ToString());
                formsPlot1.Plot.Legend();

                // Add a red circle we can move around later as a highlighted point indicator
                HighlightedPoint = formsPlot1.Plot.AddPoint(0, 0);
                HighlightedPoint.Color = Color.Red;
                HighlightedPoint.MarkerSize = 10;
                HighlightedPoint.MarkerShape = ScottPlot.MarkerShape.openCircle;
                HighlightedPoint.IsVisible = false;

                formsPlot1.Update();
                formsPlot1.Refresh();

                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox_Y.SelectedItem!= null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "fichiers png (*.png)|*.png";
                saveFileDialog1.FileName = listBox_Y.SelectedItem.ToString() + " --- " + this.Text;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;
                    Bitmap bmp_graph = formsPlot1.Plot.Render();
                    formsPlot1.Render();
                    formsPlot1.DrawToBitmap(bmp_graph, formsPlot1.ClientRectangle);
                    bmp_graph.Save(path);
                }
            }
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void formsPlot1_LeftClicked(object sender, EventArgs e)
        {
            // determine point nearest the cursor
            (double mouseCoordX, double mouseCoordY) = formsPlot1.GetMouseCoordinates();
            double xyRatio = formsPlot1.Plot.XAxis.Dims.PxPerUnit / formsPlot1.Plot.YAxis.Dims.PxPerUnit;
            (double pointX, double pointY, int pointIndex) = MyScatterPlot.GetPointNearest(mouseCoordX, mouseCoordY, xyRatio);

            // place the highlight over the point of interest
            HighlightedPoint.X = pointX;
            HighlightedPoint.Y = pointY;
            HighlightedPoint.IsVisible = true;

            // render if the highlighted point chnaged
            if (LastHighlightedIndex != pointIndex)
            {
                LastHighlightedIndex = pointIndex;
                formsPlot1.Plot.Remove(last_tooltip);
                last_tooltip = formsPlot1.Plot.AddTooltip(DateTime.FromOADate(xAxis_DateTime[pointIndex]).ToString() + "\n" + yAxis[listBox_Y.SelectedIndex][pointIndex].ToString(), pointX,pointY);
                formsPlot1.Render();
            }
        }
    }
}
