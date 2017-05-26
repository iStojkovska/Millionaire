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
    public partial class StartForm : Form
    {
        string path = "Theme_Main_-_Who_Wants_to_Be_a_Millionaire-.wav";
        SoundPlayer player;
        public StartForm()
        {
            InitializeComponent();
            BackgroundImageLayout = ImageLayout.Stretch;
            player = new SoundPlayer(path);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //player.Stop();
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.ShowDialog();
            if (form1.isClosed)
            {
                this.Visible = true;
                player.PlayLooping();
            }

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            InstructionsForm form = new InstructionsForm();
            form.ShowDialog();
        }
    }
}
