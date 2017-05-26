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
    public partial class FormFinalAnswer : Form
    {
        string path = "final answer.wav";
        SoundPlayer player;
        public FormFinalAnswer()
        {
            
            InitializeComponent();
            player = new SoundPlayer(path);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFinalAnswer_Load(object sender, EventArgs e)
        {
            player.Play();
        }

        private void FormFinalAnswer_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }

    }
}
