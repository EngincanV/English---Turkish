using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PlanningGameV1
{
    public partial class Statics : MetroFramework.Forms.MetroForm
    {
        public Statics()
        {
            InitializeComponent();
        }

        private void MBacklink_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        public void DefaultChart()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Series s0 = chart1.Series["Score"];
            s0.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 12; i++)
            {
                s0.Points.AddXY(months[i], i + 1);
                chart1.ChartAreas[0].AxisX.Maximum = i + 3;
            }
            s0.Color = Color.Transparent;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
        }
        private void Statics_Load(object sender, EventArgs e)
        {
            DefaultChart();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            switch (yearCmb.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("2018 stats are bringing...");
                    break;
                case 1:
                    MessageBox.Show("2019 stats are bringing...");
                    break;
                default:
                    break;

            }
        }
    }
}
