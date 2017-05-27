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
    public partial class WinnerForm : Form
    {
        string path = "$8,000 Win - Who Wants to Be a Millionaire- (online-audio-converter.com).wav";
        SoundPlayer player;
        public WinnerForm()
        {
            InitializeComponent();
            player = new SoundPlayer(path);
            player.Play();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }
    }
}
