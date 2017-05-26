namespace VP2017
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.chartAudience = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartAudience)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAudience
            // 
            this.chartAudience.BackColor = System.Drawing.Color.Black;
            this.chartAudience.BackSecondaryColor = System.Drawing.Color.Black;
            this.chartAudience.BorderlineColor = System.Drawing.Color.Black;
            this.chartAudience.BorderlineWidth = 0;
            this.chartAudience.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartAudience.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chartAudience.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chartAudience.ChartAreas.Add(chartArea2);
            legend2.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chartAudience.Legends.Add(legend2);
            this.chartAudience.Location = new System.Drawing.Point(-14, 12);
            this.chartAudience.Name = "chartAudience";
            this.chartAudience.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartAudience.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DodgerBlue};
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.ChartArea = "ChartArea1";
            series2.LabelBackColor = System.Drawing.Color.Maroon;
            series2.LabelBorderColor = System.Drawing.Color.Orange;
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Orange;
            series2.MarkerBorderWidth = 0;
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Name = "Точен одговор";
            this.chartAudience.Series.Add(series2);
            this.chartAudience.Size = new System.Drawing.Size(400, 261);
            this.chartAudience.TabIndex = 0;
            this.chartAudience.Text = "Публиката вели..";
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(398, 296);
            this.Controls.Add(this.chartAudience);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(404, 320);
            this.MinimumSize = new System.Drawing.Size(404, 320);
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Прашај ја публиката";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAudience)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAudience;
        private System.Windows.Forms.Timer timer1;
    }
}