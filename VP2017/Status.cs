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
    public partial class Status : Form
    {
        Color c;
        int i;
        string path = "$8,000 Win - Who Wants to Be a Millionaire- (online-audio-converter.com).wav";
        SoundPlayer player;
        public Status(int i)
        {
            this.i = i;
            c = Color.FromArgb(237, 145, 19);
            InitializeComponent();
            player = new SoundPlayer(path);
            player.Play();
            timer1.Start();
            timerBoja.Start();
            timerBoja.Tick += (s, e) =>
            this.BackColor = this.BackColor == Color.Black ? c : Color.Black;
            ProveriSuma(i);       
        }

        private void ProveriSuma(int i)
        {
            if (i == 1)
            {
                lblPrice.Text = "500";
            }
            else if (i == 2)
            {
                lblPrice.Text = "1.000";
            }
            else if (i == 3)
            {
                lblPrice.Text = "2.000";
            }
            else if (i == 4)
            {
                lblPrice.Text = "3.000";
            }
            else if (i == 5)
            {
                label1.Text = "Гарантирана сума:";
                lblPrice.Text = "5.000";
                label3.Text = "денари";
            }
            else if (i == 6)
            {
                label1.Text = "Освоена сума:";
                lblPrice.Text = "8.000";
                label3.Text = "денари";
            }
            else if (i == 7)
            {
                lblPrice.Text = "16.000";
            }
            else if (i == 8)
            {
                lblPrice.Text = "32.000";
            }
            else if (i == 9)
            {
                lblPrice.Text = "64.000";
            }
            else if (i == 10)
            {
                label1.Text = "Гарантирана сума:";
                lblPrice.Text = "125.000";
                label3.Text = "денари";
            }
            else if (i == 11)
            {
                label1.Text = "Освоена сума:";
                lblPrice.Text = "250.000";
                label3.Text = "денари";
            }
            else if (i == 12)
            {
                lblPrice.Text = "500.000";
            }
            else if (i == 13)
            {
                lblPrice.Text = "1.000.000";
            }
            else if (i == 14)
            {
                lblPrice.Text = "2.000.000";
            }
            else if (i == 15)
            {
                label1.Text = "Освоена сума:";
                lblPrice.Text = "4.000.000";
                label3.Text = "денари";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
            player.Stop();
        }

        private void Status_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();

        }
        
    }
}
