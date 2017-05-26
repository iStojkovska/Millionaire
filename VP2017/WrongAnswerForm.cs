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
    public partial class WrongAnswerForm : Form
    {

        string path = "$2,000 Lose - Who Wants to Be a Millionaire- (online-audio-converter.com).wav";
        SoundPlayer player;
        int brPrasanje;
        string correct;
        public WrongAnswerForm(int brojPrasanje, string corrAnswer)
        {
            InitializeComponent();
            player = new SoundPlayer(path);
            this.brPrasanje = brojPrasanje;
            this.correct = corrAnswer;
            player.Play();
            timer1.Start();
        }

        private void WrongAnswerForm_Load(object sender, EventArgs e)
        {
            tbTocenOdgovor.Text = correct;
            tbOsvoenaSuma.Text = string.Format("Освоена сума: {0:n0} денари",Fill());
        }

        private long Fill()
        {
            if (brPrasanje <= 5)
            {
                return 0;
            }
            else if (brPrasanje <= 10) return 5000;
            else return 125000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }

        
    }
}
