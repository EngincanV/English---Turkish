using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

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
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        SqlConnection conn;
        SqlDataReader dataReader;
        SqlCommand command;

        public void DefaultChart()
        {
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

        public void PullData()
        {
            this.chart1.Series.Clear();
            try
            {
                string connectionString;
                string[] month = new string[12];

                connectionString =
                    @"Data Source=DESKTOP-5L02G6P\SQLEXPRESS;Initial Catalog=EnglishTurkish;Integrated Security=True";
                conn = new SqlConnection(connectionString);
                conn.Open();
                string sql, output = "";
                sql = "select month, SUM(score) as 'Score Toplam' from dbo.ranking where year =" + yearCmb.SelectedItem + " group by month";
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                this.chart1.Palette = ChartColorPalette.BrightPastel;

                int[] pointsArray = new int[12];
                while (dataReader.Read())
                {
                    for (int i = 0; i < months.Length; i++)
                    {
                        if ((int)dataReader.GetValue(0) == i + 1)
                        {
                            month[i] = months[i];
                            output += month[i] + " - " + dataReader.GetValue(1).ToString() + " word is known" + "\n";
                            pointsArray[i] = (int)dataReader.GetValue(1);
                        }
                    }
                }
                SeriesCollection c = this.chart1.Series;
                c.Add("Score");
                for(int k = 0; k <months.Length; k++)
                {
                    this.chart1.Series["Score"].Points.AddXY(months[k], pointsArray[k]);
                }
                MessageBox.Show(output);
                dataReader.Close();
                command.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            switch (yearCmb.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("2018 stats are bringing...");
                    PullData();
                    break;
                case 1:
                    MessageBox.Show("2019 stats are bringing...");
                    PullData();
                    break;
                default:
                    break;
            }
        }
    }
}
