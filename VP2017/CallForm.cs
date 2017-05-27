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
    public partial class CallForm : Form
    {
        string path = "Call_a_friend_part1.wav";
        SoundPlayer startSound;
        Random random;
        int k;
        string name;
        string correctAnswer;
        string ansA;
        string ansB;
        string ansC;
        string ansD;
        string AnswerMale;
        string AnswerFemale;
        public CallForm(string correctAnswer, string ansA, string ansB, string ansC, string ansD)
        {
            InitializeComponent();
            this.correctAnswer = correctAnswer;
            this.ansA = ansA;
            this.ansB = ansB;
            this.ansC = ansC;
            this.ansD = ansD;
            startSound = new SoundPlayer(path);
            random = new Random();
            name = null;
            AnswerMale = null;
            AnswerFemale = null; 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
        private string ChooseName(int k)
        {
            string name = null;
            switch (k)
            {
                case 0:
                    name = "Елена";
                    break;
                case 1:
                    name = "Марко";
                    break;
                case 2:
                    name = "Марија";
                    break;
                case 3:
                    name = "Филип";
                    break;
                case 4:
                    name = "Ивона";
                    break;
                case 5:
                    name = "Иван";
                    break;
                case 6:
                    name = "Сара";
                    break;
                case 7:
                    name = "Виктор";
                    break;
                case 8:
                    name = "Моника";
                    break;
                case 9:
                    name = "Дарко";
                    break;
            }
            return name;
        }

        private int GeneratePercent(string btnAnswer, string correctAnswer)
        {
            int percent = 0;
            if (btnAnswer == correctAnswer)
            {
                int pom = random.Next(80, 101);
                percent = (int)pom / 10 * 10;
            }
            else
            {
                int pom = random.Next(20, 80);
                percent = (int)pom / 10 * 10;
            }
            return percent;
        }

        private void GenerateAnswerString(string answer, int percent)
        {
            AnswerFemale = string.Format("Мојот одговор е „{0}“, сигурна сум {1}%", answer, percent);
            AnswerMale = string.Format("Мојот одговор е „{0}“, сигурен сум {1}%", answer, percent);
        }

        private void GenerateAnswer(int k)
        {

            int percent = 0;
            switch (k)
            {
                case 0:

                    percent = GeneratePercent(ansA, correctAnswer);
                    GenerateAnswerString(ansA, percent);
                    break;
                case 1:
                    percent = GeneratePercent(ansB, correctAnswer);
                    GenerateAnswerString(ansB, percent);
                    break;
                case 2:
                    percent = GeneratePercent(ansC, correctAnswer);
                    GenerateAnswerString(ansC, percent);
                    break;
                case 3:
                    percent = GeneratePercent(ansD, correctAnswer);
                    GenerateAnswerString(ansD, percent);
                    break;
            }
        }

        private int CheckIfEmpty(int k)
        {
            if (k == 0 && ansA.Length==0)
            {
                k = 1;
            }
            if (k == 1 && ansB.Length == 0)
            {
                k = 2;
            }
            if (k == 2 && ansC.Length == 0)
            {
                k = 3;
            }
            if (k == 3 && ansD.Length==0)
            {
                k = 0;
            }
            return k;
        }

        private void CallForm_Load(object sender, EventArgs e)
        {
            k = random.Next(0, 10);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            name = ChooseName(k);
            bool isFemale=false;
            if(k%2==0)
            {
                isFemale=true;
            }
            k = random.Next(0, 4);
            k=CheckIfEmpty(k);
            GenerateAnswer(k);
            if (isFemale)
            {
                tbNameAnswer.Text = string.Format("{0}: {1}", name, AnswerFemale);
            }
            else
            {
                tbNameAnswer.Text = string.Format("{0}: {1}", name, AnswerMale);
            }
            startSound.Play();
        }

        private void CallForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            startSound.Stop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
