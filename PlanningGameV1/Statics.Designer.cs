namespace PlanningGameV1
{
    partial class Statics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statics));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.yearCmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.MBacklink = new MetroFramework.Controls.MetroLink();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // yearCmb
            // 
            this.yearCmb.FormattingEnabled = true;
            this.yearCmb.ItemHeight = 24;
            this.yearCmb.Items.AddRange(new object[] {
            "2018",
            "2019"});
            this.yearCmb.Location = new System.Drawing.Point(82, 179);
            this.yearCmb.Name = "yearCmb";
            this.yearCmb.Size = new System.Drawing.Size(121, 30);
            this.yearCmb.TabIndex = 1;
            this.yearCmb.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(127, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Year:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(82, 248);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 31);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Bring the stats";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // MBacklink
            // 
            this.MBacklink.ForeColor = System.Drawing.Color.White;
            this.MBacklink.Image = ((System.Drawing.Image)(resources.GetObject("MBacklink.Image")));
            this.MBacklink.ImageSize = 23;
            this.MBacklink.Location = new System.Drawing.Point(24, 24);
            this.MBacklink.Margin = new System.Windows.Forms.Padding(4);
            this.MBacklink.Name = "MBacklink";
            this.MBacklink.Size = new System.Drawing.Size(45, 32);
            this.MBacklink.TabIndex = 13;
            this.MBacklink.UseCustomBackColor = true;
            this.MBacklink.UseCustomForeColor = true;
            this.MBacklink.UseSelectable = true;
            this.MBacklink.Click += new System.EventHandler(this.MBacklink_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(293, 24);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Score";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(484, 385);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            title1.Name = "Point Stats";
            this.chart1.Titles.Add(title1);
            // 
            // Statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.MBacklink);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.yearCmb);
            this.Name = "Statics";
            this.Text = "         Statics";
            this.Load += new System.EventHandler(this.Statics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox yearCmb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLink MBacklink;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}