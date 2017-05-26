namespace VP2017
{
    partial class FormFinalAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinalAnswer));
            this.lblKonecenOdgovor = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnNe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKonecenOdgovor
            // 
            this.lblKonecenOdgovor.AutoSize = true;
            this.lblKonecenOdgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKonecenOdgovor.ForeColor = System.Drawing.Color.White;
            this.lblKonecenOdgovor.Location = new System.Drawing.Point(12, 34);
            this.lblKonecenOdgovor.Name = "lblKonecenOdgovor";
            this.lblKonecenOdgovor.Size = new System.Drawing.Size(364, 25);
            this.lblKonecenOdgovor.TabIndex = 2;
            this.lblKonecenOdgovor.Text = "Дали е тоа Вашиот конечен одговор?";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(12, 99);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(170, 35);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Да";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNe
            // 
            this.btnNe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNe.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNe.Location = new System.Drawing.Point(198, 99);
            this.btnNe.Name = "btnNe";
            this.btnNe.Size = new System.Drawing.Size(170, 35);
            this.btnNe.TabIndex = 5;
            this.btnNe.Text = "Не";
            this.btnNe.UseVisualStyleBackColor = false;
            this.btnNe.Click += new System.EventHandler(this.btnNe_Click);
            // 
            // FormFinalAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(380, 149);
            this.Controls.Add(this.btnNe);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblKonecenOdgovor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(396, 187);
            this.MinimumSize = new System.Drawing.Size(396, 187);
            this.Name = "FormFinalAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFinalAnswer_FormClosed);
            this.Load += new System.EventHandler(this.FormFinalAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKonecenOdgovor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNe;

    }
}