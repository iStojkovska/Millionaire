using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace VP2017
{
    public partial class ChartForm : Form
    {
        private int a;
        private int b;
        private int c;
        private int d;
        string path = "Who-Wants-to-be-a-Millionaire-Ask-the-Audience-Poll.wav";
        SoundPlayer player;
        public ChartForm(int a, int b, int c, int d)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            player = new SoundPlayer(path);
            player.Play();
            timer1.Start();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
           // chartAudience.ChartAreas[0].AxisX.LineColor = Color.Red;
           // chartAudience.ChartAreas[0].AxisY.LineColor = Color.Red;
            chartAudience.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chartAudience.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartAudience.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chartAudience.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chartAudience.ChartAreas[0].AxisY.Maximum = 100;
            chartAudience.ChartAreas[0].AxisY.Minimum = 0;
            chartAudience.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chartAudience.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartAudience.Series["Точен одговор"].Points.AddXY("A", a);
            chartAudience.Series["Точен одговор"].Points.AddXY("B", b);
            chartAudience.Series["Точен одговор"].Points.AddXY("C", c);
            chartAudience.Series["Точен одговор"].Points.AddXY("D", d);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }
    }
}
