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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.chartAudience = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
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
            chartArea1.Name = "ChartArea1";
            this.chartAudience.ChartAreas.Add(chartArea1);
            legend1.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartAudience.Legends.Add(legend1);
            this.chartAudience.Location = new System.Drawing.Point(-14, 12);
            this.chartAudience.Name = "chartAudience";
            this.chartAudience.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartAudience.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DodgerBlue};
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.LabelBackColor = System.Drawing.Color.Maroon;
            series1.LabelBorderColor = System.Drawing.Color.Orange;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Orange;
            series1.MarkerBorderWidth = 0;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Name = "Точен одговор";
            this.chartAudience.Series.Add(series1);
            this.chartAudience.Size = new System.Drawing.Size(400, 261);
            this.chartAudience.TabIndex = 0;
            this.chartAudience.Text = "Публиката вели..";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(245, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 46);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Затвори";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(398, 296);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chartAudience);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(404, 320);
            this.MinimumSize = new System.Drawing.Size(404, 320);
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Прашај ја публиката";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChartForm_FormClosed);
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAudience)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAudience;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
    }
}