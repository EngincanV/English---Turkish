using System;
using System.Drawing;

namespace PlanningGameV1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = MetroStyleManager;
            PodcastTile.Style = MetroFramework.MetroColorStyle.Blue;
            TryYourselfTile.Style = MetroFramework.MetroColorStyle.Yellow;
            AddWordsTile.Style = MetroFramework.MetroColorStyle.Purple;
        }

        private void ThemeCbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ThemeCbn.SelectedIndex)
            {
                case 0:
                    MetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                    pictureBox1.BackColor = Color.Transparent;
                    break;
                case 1:
                    MetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                    pictureBox1.BackColor = Color.White;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThemeCbn.SelectedIndex = 0;
        }

        private void PodcastTile_Click(object sender, EventArgs e)
        {
            PodCast pod = new PodCast();
            pod.Show();
            this.Hide();
        }

        private void AddWordsTile_Click(object sender, EventArgs e)
        {
            AddWords add = new AddWords();
            add.Show();
            this.Hide();
        }
    }
}
