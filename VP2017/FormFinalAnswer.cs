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
    public partial class FormFinalAnswer : Form
    {
        
        public FormFinalAnswer()
        {
            
            InitializeComponent();
            
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

    }
}
