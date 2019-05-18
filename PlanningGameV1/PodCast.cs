using PlanningGameV1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanningGameV1
{
    public partial class PodCast : Form
    {
        public PodCast()
        {
            InitializeComponent();
        }
        private void MBacklink_Click(object sender, System.EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void PauseBtn_Click(object sender, System.EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void StopBtn_Click(object sender, System.EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void ListMusic_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {
            ListMucisUrl.SelectedIndex = ListMusic.SelectedIndex;
            axWindowsMediaPlayer1.URL = ListMucisUrl.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        EnglishTurkishEntities2 db = new EnglishTurkishEntities2();
        tblMusic d = new tblMusic();
        private void PodCast_Load(object sender, System.EventArgs e)
        {
            //linq to sql query
            var mucis = from a in db.tblMusics select a;
            foreach (var item in mucis)
            {
                ListMucisUrl.Items.Add(item.musicPath);
                ListMusic.Items.Add(item.musicName);
            }
            axWindowsMediaPlayer1.Visible = false;
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void ListMucisUrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
