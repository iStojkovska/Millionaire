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
    public partial class ExitForm : Form
    {
        string path = "$2,000 Lose - Who Wants to Be a Millionaire- (online-audio-converter.com).wav";
        SoundPlayer player;
        int brojPrasanje;
        public ExitForm(int brojPrasanje)
        {
            InitializeComponent();
            player = new SoundPlayer(path);
            this.brojPrasanje = brojPrasanje-1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
        private long GenerateSum(int i)
        {
            long suma = 0;
            switch (i)
            { 
                case 0:
                    suma = 0;
                    break;
                case 1:
                    suma = 500;
                    break;
                case 2:
                    suma = 1000;
                    break;
                case 3:
                    suma = 2000;
                    break;
                case 4:
                    suma = 3000;
                    break;
                case 5:
                    suma = 5000;
                    break;
                case 6:
                    suma = 8000;
                    break;
                case 7:
                    suma = 16000;
                    break;
                case 8:
                    suma = 32000;
                    break;
                case 9:
                    suma = 64000;
                    break;
                case 10:
                    suma = 125000;
                    break;
                case 11:
                    suma = 250000;
                    break;
                case 12:
                    suma = 500000;
                    break;
                case 13:
                    suma = 1000000;
                    break;
                case 14:
                    suma = 2000000;
                    break;
                case 15:
                    suma = 4000000;
                    break;
            }
            return suma;
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FormFinalAnswer_Load(object sender, EventArgs e)
        {
            tbKolkuDenari.Text = string.Format("{0:n0} денари", GenerateSum(brojPrasanje));
            player.Play();
        }

        private void FormFinalAnswer_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }

    }
}
