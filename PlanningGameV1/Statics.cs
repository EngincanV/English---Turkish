using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Statics_Load(object sender, EventArgs e)
        {
            
        }
    }
}
