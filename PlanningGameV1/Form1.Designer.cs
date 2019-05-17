namespace PlanningGameV1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ThemeCbn = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MetroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TryYourselfTile = new MetroFramework.Controls.MetroTile();
            this.LearnWordsTile = new MetroFramework.Controls.MetroTile();
            this.PodcastTile = new MetroFramework.Controls.MetroTile();
            this.AddWordsTile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemeCbn
            // 
            this.ThemeCbn.DisplayMember = "0";
            this.ThemeCbn.FormattingEnabled = true;
            this.ThemeCbn.ItemHeight = 24;
            this.ThemeCbn.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.ThemeCbn.Location = new System.Drawing.Point(493, 53);
            this.ThemeCbn.Margin = new System.Windows.Forms.Padding(2);
            this.ThemeCbn.Name = "ThemeCbn";
            this.ThemeCbn.Size = new System.Drawing.Size(92, 30);
            this.ThemeCbn.TabIndex = 1;
            this.ThemeCbn.UseSelectable = true;
            this.ThemeCbn.SelectedIndexChanged += new System.EventHandler(this.ThemeCbn_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(420, 53);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Theme:";
            // 
            // MetroStyleManager
            // 
            this.MetroStyleManager.Owner = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlanningGameV1.Properties.Resources.iconfinder_vector_65_02_473778;
            this.pictureBox1.Location = new System.Drawing.Point(420, 122);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TryYourselfTile
            // 
            this.TryYourselfTile.ActiveControl = null;
            this.TryYourselfTile.Location = new System.Drawing.Point(219, 220);
            this.TryYourselfTile.Margin = new System.Windows.Forms.Padding(2);
            this.TryYourselfTile.Name = "TryYourselfTile";
            this.TryYourselfTile.Size = new System.Drawing.Size(141, 81);
            this.TryYourselfTile.TabIndex = 2;
            this.TryYourselfTile.Text = "Try Yourself";
            this.TryYourselfTile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TryYourselfTile.TileImage = ((System.Drawing.Image)(resources.GetObject("TryYourselfTile.TileImage")));
            this.TryYourselfTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TryYourselfTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TryYourselfTile.UseSelectable = true;
            this.TryYourselfTile.UseTileImage = true;
            // 
            // LearnWordsTile
            // 
            this.LearnWordsTile.ActiveControl = null;
            this.LearnWordsTile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LearnWordsTile.Location = new System.Drawing.Point(219, 122);
            this.LearnWordsTile.Margin = new System.Windows.Forms.Padding(2);
            this.LearnWordsTile.Name = "LearnWordsTile";
            this.LearnWordsTile.Size = new System.Drawing.Size(141, 81);
            this.LearnWordsTile.TabIndex = 2;
            this.LearnWordsTile.Text = "Learn Words";
            this.LearnWordsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("LearnWordsTile.TileImage")));
            this.LearnWordsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LearnWordsTile.UseSelectable = true;
            this.LearnWordsTile.UseTileImage = true;
            this.LearnWordsTile.Click += new System.EventHandler(this.LearnWordsTile_Click);
            // 
            // PodcastTile
            // 
            this.PodcastTile.ActiveControl = null;
            this.PodcastTile.Location = new System.Drawing.Point(52, 220);
            this.PodcastTile.Margin = new System.Windows.Forms.Padding(2);
            this.PodcastTile.Name = "PodcastTile";
            this.PodcastTile.Size = new System.Drawing.Size(141, 81);
            this.PodcastTile.TabIndex = 2;
            this.PodcastTile.TileImage = ((System.Drawing.Image)(resources.GetObject("PodcastTile.TileImage")));
            this.PodcastTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PodcastTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.PodcastTile.UseSelectable = true;
            this.PodcastTile.UseTileImage = true;
            this.PodcastTile.Click += new System.EventHandler(this.PodcastTile_Click);
            // 
            // AddWordsTile
            // 
            this.AddWordsTile.ActiveControl = null;
            this.AddWordsTile.ForeColor = System.Drawing.Color.Black;
            this.AddWordsTile.Location = new System.Drawing.Point(52, 122);
            this.AddWordsTile.Margin = new System.Windows.Forms.Padding(2);
            this.AddWordsTile.Name = "AddWordsTile";
            this.AddWordsTile.Size = new System.Drawing.Size(141, 81);
            this.AddWordsTile.TabIndex = 2;
            this.AddWordsTile.Text = "Add Words";
            this.AddWordsTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddWordsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("AddWordsTile.TileImage")));
            this.AddWordsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddWordsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddWordsTile.UseSelectable = true;
            this.AddWordsTile.UseTileImage = true;
            this.AddWordsTile.Click += new System.EventHandler(this.AddWordsTile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(601, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TryYourselfTile);
            this.Controls.Add(this.LearnWordsTile);
            this.Controls.Add(this.PodcastTile);
            this.Controls.Add(this.AddWordsTile);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ThemeCbn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(601, 369);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(601, 369);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 15);
            this.Text = "    Planning Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ThemeCbn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile AddWordsTile;
        private MetroFramework.Controls.MetroTile LearnWordsTile;
        private MetroFramework.Controls.MetroTile PodcastTile;
        private MetroFramework.Controls.MetroTile TryYourselfTile;
        private MetroFramework.Components.MetroStyleManager MetroStyleManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

