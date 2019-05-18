namespace PlanningGameV1
{
    partial class PodCast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodCast));
            this.MBacklink = new MetroFramework.Controls.MetroLink();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ListMusic = new MetroFramework.Controls.MetroComboBox();
            this.PlayBtn = new MetroFramework.Controls.MetroLink();
            this.PauseBtn = new MetroFramework.Controls.MetroLink();
            this.StopBtn = new MetroFramework.Controls.MetroLink();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ListMucisUrl = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // MBacklink
            // 
            this.MBacklink.ForeColor = System.Drawing.Color.White;
            this.MBacklink.Image = ((System.Drawing.Image)(resources.GetObject("MBacklink.Image")));
            this.MBacklink.ImageSize = 23;
            this.MBacklink.Location = new System.Drawing.Point(31, 30);
            this.MBacklink.Margin = new System.Windows.Forms.Padding(4);
            this.MBacklink.Name = "MBacklink";
            this.MBacklink.Size = new System.Drawing.Size(45, 32);
            this.MBacklink.TabIndex = 6;
            this.MBacklink.UseCustomBackColor = true;
            this.MBacklink.UseCustomForeColor = true;
            this.MBacklink.UseSelectable = true;
            this.MBacklink.Click += new System.EventHandler(this.MBacklink_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(23, 328);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(269, 29);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // ListMusic
            // 
            this.ListMusic.FormattingEnabled = true;
            this.ListMusic.ItemHeight = 24;
            this.ListMusic.Location = new System.Drawing.Point(213, 164);
            this.ListMusic.Margin = new System.Windows.Forms.Padding(4);
            this.ListMusic.Name = "ListMusic";
            this.ListMusic.Size = new System.Drawing.Size(357, 30);
            this.ListMusic.TabIndex = 8;
            this.ListMusic.UseSelectable = true;
            this.ListMusic.SelectedIndexChanged += new System.EventHandler(this.ListMusic_SelectedIndexChanged_1);
            // 
            // PlayBtn
            // 
            this.PlayBtn.ForeColor = System.Drawing.Color.White;
            this.PlayBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlayBtn.Image")));
            this.PlayBtn.ImageSize = 28;
            this.PlayBtn.Location = new System.Drawing.Point(265, 225);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(73, 47);
            this.PlayBtn.TabIndex = 9;
            this.PlayBtn.UseCustomBackColor = true;
            this.PlayBtn.UseCustomForeColor = true;
            this.PlayBtn.UseSelectable = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.ForeColor = System.Drawing.Color.White;
            this.PauseBtn.Image = ((System.Drawing.Image)(resources.GetObject("PauseBtn.Image")));
            this.PauseBtn.ImageSize = 32;
            this.PauseBtn.Location = new System.Drawing.Point(359, 225);
            this.PauseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(69, 47);
            this.PauseBtn.TabIndex = 10;
            this.PauseBtn.UseCustomBackColor = true;
            this.PauseBtn.UseCustomForeColor = true;
            this.PauseBtn.UseSelectable = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.ForeColor = System.Drawing.Color.White;
            this.StopBtn.Image = ((System.Drawing.Image)(resources.GetObject("StopBtn.Image")));
            this.StopBtn.ImageSize = 28;
            this.StopBtn.Location = new System.Drawing.Point(437, 225);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(84, 47);
            this.StopBtn.TabIndex = 11;
            this.StopBtn.UseCustomBackColor = true;
            this.StopBtn.UseCustomForeColor = true;
            this.StopBtn.UseSelectable = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // ListMucisUrl
            // 
            this.ListMucisUrl.FormattingEnabled = true;
            this.ListMucisUrl.ItemHeight = 24;
            this.ListMucisUrl.Location = new System.Drawing.Point(397, 404);
            this.ListMucisUrl.Margin = new System.Windows.Forms.Padding(4);
            this.ListMucisUrl.Name = "ListMucisUrl";
            this.ListMucisUrl.Size = new System.Drawing.Size(357, 30);
            this.ListMucisUrl.TabIndex = 13;
            this.ListMucisUrl.UseSelectable = true;
            this.ListMucisUrl.Visible = false;
            this.ListMucisUrl.SelectedIndexChanged += new System.EventHandler(this.ListMucisUrl_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(340, 100);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 25);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Podcasts";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // PodCast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(801, 454);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ListMucisUrl);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.ListMusic);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.MBacklink);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(801, 454);
            this.MinimumSize = new System.Drawing.Size(801, 454);
            this.Name = "PodCast";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 18);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PodCast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLink MBacklink;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MetroFramework.Controls.MetroComboBox ListMusic;
        private MetroFramework.Controls.MetroLink PlayBtn;
        private MetroFramework.Controls.MetroLink PauseBtn;
        private MetroFramework.Controls.MetroLink StopBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroComboBox ListMucisUrl;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}