namespace VP2017
{
    partial class WinnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnerForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.tbKolkuDenari = new System.Windows.Forms.TextBox();
            this.tbOtkaziSe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(209, 140);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 46);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Затвори";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbKolkuDenari
            // 
            this.tbKolkuDenari.BackColor = System.Drawing.Color.Black;
            this.tbKolkuDenari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKolkuDenari.Enabled = false;
            this.tbKolkuDenari.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKolkuDenari.ForeColor = System.Drawing.Color.White;
            this.tbKolkuDenari.Location = new System.Drawing.Point(12, 69);
            this.tbKolkuDenari.Multiline = true;
            this.tbKolkuDenari.Name = "tbKolkuDenari";
            this.tbKolkuDenari.ReadOnly = true;
            this.tbKolkuDenari.Size = new System.Drawing.Size(527, 54);
            this.tbKolkuDenari.TabIndex = 10;
            this.tbKolkuDenari.Text = "ОСВОИВТЕ 4.000.000 ДЕНАРИ!";
            this.tbKolkuDenari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOtkaziSe
            // 
            this.tbOtkaziSe.BackColor = System.Drawing.Color.Black;
            this.tbOtkaziSe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOtkaziSe.Enabled = false;
            this.tbOtkaziSe.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOtkaziSe.ForeColor = System.Drawing.Color.White;
            this.tbOtkaziSe.Location = new System.Drawing.Point(100, 12);
            this.tbOtkaziSe.Multiline = true;
            this.tbOtkaziSe.Name = "tbOtkaziSe";
            this.tbOtkaziSe.ReadOnly = true;
            this.tbOtkaziSe.Size = new System.Drawing.Size(356, 63);
            this.tbOtkaziSe.TabIndex = 9;
            this.tbOtkaziSe.Text = "Честитаме!";
            this.tbOtkaziSe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(551, 214);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbKolkuDenari);
            this.Controls.Add(this.tbOtkaziSe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Победивте!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbKolkuDenari;
        private System.Windows.Forms.TextBox tbOtkaziSe;
    }
}