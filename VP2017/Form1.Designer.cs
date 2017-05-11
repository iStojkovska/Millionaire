namespace VP2017
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.pbCall = new System.Windows.Forms.PictureBox();
            this.pbAskTheAudience = new System.Windows.Forms.PictureBox();
            this.pbQuestions = new System.Windows.Forms.PictureBox();
            this.pb5050 = new System.Windows.Forms.PictureBox();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAskTheAudience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5050)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbQuestion.Enabled = false;
            this.tbQuestion.Font = new System.Drawing.Font("Arial Narrow", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuestion.ForeColor = System.Drawing.Color.White;
            this.tbQuestion.Location = new System.Drawing.Point(109, 188);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(340, 51);
            this.tbQuestion.TabIndex = 12;
            this.tbQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuestion.LocationChanged += new System.EventHandler(this.tbQuestion_LocationChanged);
            // 
            // pbCall
            // 
            this.pbCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCall.Location = new System.Drawing.Point(653, 160);
            this.pbCall.Name = "pbCall";
            this.pbCall.Size = new System.Drawing.Size(91, 79);
            this.pbCall.TabIndex = 6;
            this.pbCall.TabStop = false;
            // 
            // pbAskTheAudience
            // 
            this.pbAskTheAudience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAskTheAudience.Location = new System.Drawing.Point(653, 278);
            this.pbAskTheAudience.Name = "pbAskTheAudience";
            this.pbAskTheAudience.Size = new System.Drawing.Size(91, 79);
            this.pbAskTheAudience.TabIndex = 5;
            this.pbAskTheAudience.TabStop = false;
            // 
            // pbQuestions
            // 
            this.pbQuestions.BackColor = System.Drawing.Color.Transparent;
            this.pbQuestions.Location = new System.Drawing.Point(29, 176);
            this.pbQuestions.Name = "pbQuestions";
            this.pbQuestions.Size = new System.Drawing.Size(501, 237);
            this.pbQuestions.TabIndex = 4;
            this.pbQuestions.TabStop = false;
            // 
            // pb5050
            // 
            this.pb5050.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5050.Location = new System.Drawing.Point(653, 49);
            this.pb5050.Name = "pb5050";
            this.pb5050.Size = new System.Drawing.Size(91, 79);
            this.pb5050.TabIndex = 1;
            this.pb5050.TabStop = false;
            this.pb5050.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb5050_MouseClick);
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.BackColor = System.Drawing.Color.Black;
            this.btnAnswerA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnswerA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswerA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnswerA.FlatAppearance.BorderSize = 0;
            this.btnAnswerA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerA.ForeColor = System.Drawing.Color.White;
            this.btnAnswerA.Location = new System.Drawing.Point(42, 288);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(214, 31);
            this.btnAnswerA.TabIndex = 14;
            this.btnAnswerA.Text = "Answer A";
            this.btnAnswerA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswerA.UseVisualStyleBackColor = false;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswerA_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.BackColor = System.Drawing.Color.Black;
            this.btnAnswerB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnswerB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswerB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnswerB.FlatAppearance.BorderSize = 0;
            this.btnAnswerB.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerB.ForeColor = System.Drawing.Color.White;
            this.btnAnswerB.Location = new System.Drawing.Point(302, 288);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(214, 31);
            this.btnAnswerB.TabIndex = 18;
            this.btnAnswerB.Text = "Answer B";
            this.btnAnswerB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswerB.UseVisualStyleBackColor = false;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswerB_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.BackColor = System.Drawing.Color.Black;
            this.btnAnswerC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnswerC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswerC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnswerC.FlatAppearance.BorderSize = 0;
            this.btnAnswerC.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerC.ForeColor = System.Drawing.Color.White;
            this.btnAnswerC.Location = new System.Drawing.Point(42, 366);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(214, 31);
            this.btnAnswerC.TabIndex = 19;
            this.btnAnswerC.Text = "Answer C";
            this.btnAnswerC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswerC.UseVisualStyleBackColor = false;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswerC_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.BackColor = System.Drawing.Color.Black;
            this.btnAnswerD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnswerD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswerD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnswerD.FlatAppearance.BorderSize = 0;
            this.btnAnswerD.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswerD.ForeColor = System.Drawing.Color.White;
            this.btnAnswerD.Location = new System.Drawing.Point(302, 366);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(214, 31);
            this.btnAnswerD.TabIndex = 20;
            this.btnAnswerD.Text = "Answer D";
            this.btnAnswerD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswerD.UseVisualStyleBackColor = false;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswerD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(642, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 447);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            this.imageList1.Images.SetKeyName(2, "3.jpg");
            this.imageList1.Images.SetKeyName(3, "4.jpg");
            this.imageList1.Images.SetKeyName(4, "5.jpg");
            this.imageList1.Images.SetKeyName(5, "6.jpg");
            this.imageList1.Images.SetKeyName(6, "7.jpg");
            this.imageList1.Images.SetKeyName(7, "8.jpg");
            this.imageList1.Images.SetKeyName(8, "9.jpg");
            this.imageList1.Images.SetKeyName(9, "10.jpg");
            this.imageList1.Images.SetKeyName(10, "11.jpg");
            this.imageList1.Images.SetKeyName(11, "12.jpg");
            this.imageList1.Images.SetKeyName(12, "13.jpg");
            this.imageList1.Images.SetKeyName(13, "14.jpg");
            this.imageList1.Images.SetKeyName(14, "15.jpg");
            this.imageList1.Images.SetKeyName(15, "Background.jpg");
            this.imageList1.Images.SetKeyName(16, "Classic5050.png");
            this.imageList1.Images.SetKeyName(17, "Classic5050X.png");
            this.imageList1.Images.SetKeyName(18, "ClassicATA.png");
            this.imageList1.Images.SetKeyName(19, "ClassicATAX.png");
            this.imageList1.Images.SetKeyName(20, "Initial_Bar.PNG");
            this.imageList1.Images.SetKeyName(21, "logo.gif");
            this.imageList1.Images.SetKeyName(22, "logo_ram_icon.ico");
            this.imageList1.Images.SetKeyName(23, "P15POBEDA.jpg");
            this.imageList1.Images.SetKeyName(24, "P15POBEDA2.jpg");
            this.imageList1.Images.SetKeyName(25, "phoneAFriend.png");
            this.imageList1.Images.SetKeyName(26, "phoneAFriendX.png");
            this.imageList1.Images.SetKeyName(27, "qBox.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::VP2017.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(756, 417);
            this.Controls.Add(this.pb5050);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.pbCall);
            this.Controls.Add(this.pbAskTheAudience);
            this.Controls.Add(this.pbQuestions);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAskTheAudience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5050)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb5050;
        private System.Windows.Forms.PictureBox pbQuestions;
        private System.Windows.Forms.PictureBox pbAskTheAudience;
        private System.Windows.Forms.PictureBox pbCall;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

