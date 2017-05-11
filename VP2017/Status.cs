using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VP2017
{
    public partial class Status : Form
    {
        int i;
        public Status(int i)
        {
            this.i = i;
            InitializeComponent();
            timer1.Start();
            BackgroundImage = imageList1.Images[i - 1];
            
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
