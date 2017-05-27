namespace VP2017
{
    partial class WrongAnswerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WrongAnswerForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbOtkaziSe = new System.Windows.Forms.TextBox();
            this.tbTocenOdgovor = new System.Windows.Forms.TextBox();
            this.tbOsvoenaSuma = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbOtkaziSe
            // 
            this.tbOtkaziSe.BackColor = System.Drawing.Color.Black;
            this.tbOtkaziSe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOtkaziSe.Enabled = false;
            this.tbOtkaziSe.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOtkaziSe.ForeColor = System.Drawing.Color.White;
            this.tbOtkaziSe.Location = new System.Drawing.Point(12, 12);
            this.tbOtkaziSe.Multiline = true;
            this.tbOtkaziSe.Name = "tbOtkaziSe";
            this.tbOtkaziSe.ReadOnly = true;
            this.tbOtkaziSe.Size = new System.Drawing.Size(356, 39);
            this.tbOtkaziSe.TabIndex = 7;
            this.tbOtkaziSe.Text = "Точниот одговор е:";
            this.tbOtkaziSe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTocenOdgovor
            // 
            this.tbTocenOdgovor.BackColor = System.Drawing.Color.Black;
            this.tbTocenOdgovor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTocenOdgovor.Enabled = false;
            this.tbTocenOdgovor.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTocenOdgovor.ForeColor = System.Drawing.Color.White;
            this.tbTocenOdgovor.Location = new System.Drawing.Point(12, 46);
            this.tbTocenOdgovor.Multiline = true;
            this.tbTocenOdgovor.Name = "tbTocenOdgovor";
            this.tbTocenOdgovor.ReadOnly = true;
            this.tbTocenOdgovor.Size = new System.Drawing.Size(356, 39);
            this.tbTocenOdgovor.TabIndex = 8;
            this.tbTocenOdgovor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOsvoenaSuma
            // 
            this.tbOsvoenaSuma.BackColor = System.Drawing.Color.Black;
            this.tbOsvoenaSuma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOsvoenaSuma.Enabled = false;
            this.tbOsvoenaSuma.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOsvoenaSuma.ForeColor = System.Drawing.Color.White;
            this.tbOsvoenaSuma.Location = new System.Drawing.Point(12, 91);
            this.tbOsvoenaSuma.Multiline = true;
            this.tbOsvoenaSuma.Name = "tbOsvoenaSuma";
            this.tbOsvoenaSuma.ReadOnly = true;
            this.tbOsvoenaSuma.Size = new System.Drawing.Size(356, 46);
            this.tbOsvoenaSuma.TabIndex = 9;
            this.tbOsvoenaSuma.Text = "Освоивте:";
            this.tbOsvoenaSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(356, 39);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Повеќе среќа следниот пат!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WrongAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 184);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbOsvoenaSuma);
            this.Controls.Add(this.tbTocenOdgovor);
            this.Controls.Add(this.tbOtkaziSe);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(388, 208);
            this.MinimumSize = new System.Drawing.Size(388, 208);
            this.Name = "WrongAnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WrongAnswerForm_FormClosed);
            this.Load += new System.EventHandler(this.WrongAnswerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbOtkaziSe;
        private System.Windows.Forms.TextBox tbTocenOdgovor;
        private System.Windows.Forms.TextBox tbOsvoenaSuma;
        private System.Windows.Forms.TextBox textBox1;
    }
}