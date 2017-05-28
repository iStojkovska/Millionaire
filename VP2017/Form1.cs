using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web;
using System.IO;

namespace VP2017
{
    public partial class Form1 : Form
    {
        #region Variables
        string correctAnswer;
        int i;
        List<int> Pominati;
        int id;
        int corrButton;
        List<int> Answers;
        int SecondAnswer5050;
        bool Clicked_5050;
        bool Clicked_audience;
        bool Clicked_phoneFriend;
        public bool isClosed;        
        List<int> VrednostiABCD;
        Random random;
        string path = "1001000 music.wav";
        SoundPlayer play;
        #endregion

        #region Constructor_Form1, Load method and Close method
        public Form1()
        {
            InitializeComponent();
            corrButton = 0;
            BackgroundImageLayout = ImageLayout.Stretch;
            correctAnswer = "";
            i = 1;
            Pominati = new List<int>();
            id=0;
            Answers = new List<int>();
            SecondAnswer5050 = 0;
            Clicked_5050 = false;
            Clicked_audience = false;
            Clicked_phoneFriend = false;
            isClosed = false;
            VrednostiABCD = new List<int>();
            random = new Random();
            play = new SoundPlayer(path);
        }
     
       
        private void Form1_Load(object sender, EventArgs e)
        {
            pb5050.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5050.Image = imageList1.Images[16];
            pbAskTheAudience.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAskTheAudience.Image = imageList1.Images[18];
            pbCall.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCall.Image = imageList1.Images[25];
            pbOtkaziSe.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOtkaziSe.Image = imageList1.Images[28];
            pbQuestions.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuestions.Image = imageList1.Images[27];
            PopolniPrasanje();
            //dodadeno!!!
            play.PlayLooping();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //dodadeno!!!
            play.Stop();
            isClosed = true;
        }
        #endregion 

        #region Functions

        private void PopolniPrasanje()
        {
            //dodadeno!!!
            play.PlayLooping();

            EnableButtons();
            if (i <= 5)
            {
                PopolniPrasanje1();
            }
            else if (i <= 10)
            {
                if (i == 6)
                {
                    Pominati = new List<int>();
                }
                PopolniPrasanje2();
            }
            else if (i <= 15)
            {
                if (i == 11)
                {
                    Pominati = new List<int>();
                }

                PopolniPrasanje3();
            }
        }
        private void GenerateTryBlockForQuestions(SqlConnection connection, SqlCommand cmd, int k)
        {
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (i <= 5)
            {

                while (sdr.Read())
                {
                    id = (int)sdr["questID"];
                    tbQuestion.Text = sdr["quest"].ToString();
                    btnAnswerA.Text = sdr["a"].ToString();
                    btnAnswerB.Text = sdr["b"].ToString();
                    btnAnswerC.Text = sdr["c"].ToString();
                    btnAnswerD.Text = sdr["d"].ToString();
                    correctAnswer = sdr["answ"].ToString();
                    if (id == k)
                    {
                        break;
                    }

                }
            }
            else
            {
                while (sdr.Read())
                {
                    id = (int)sdr["quest_id"];
                    tbQuestion.Text = sdr["quest"].ToString();
                    btnAnswerA.Text = sdr["a"].ToString();
                    btnAnswerB.Text = sdr["b"].ToString();
                    btnAnswerC.Text = sdr["c"].ToString();
                    btnAnswerD.Text = sdr["d"].ToString();
                    correctAnswer = sdr["answ"].ToString();
                    if (id == k)
                    {
                        break;
                    }

                }
            }             
        }
        private int GenerateQuestionNumber()
        {
            int k = 0;
            int lowestQuestionID=0;
            int highestQuestionID=0;
            if (i <= 5)
            {
                lowestQuestionID = 6;
                highestQuestionID = 38;
            }
            else if (i <= 10)
            {
                lowestQuestionID = 1;
                highestQuestionID = 28;
            }
            else if (i <= 15)
            {
                lowestQuestionID = 1;
                highestQuestionID = 18;
            }
            k = random.Next(lowestQuestionID, highestQuestionID);
            while (Pominati.Contains(k))
            {
                k = random.Next(lowestQuestionID, highestQuestionID);
            }
            Pominati.Add(k);
            return k;
        }
        private void PopolniPrasanje1()
        {
            string sqlStr = "SELECT * FROM Level1";
            SqlConnection connection = new SqlConnection();
            string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DataBase\Questions.mdf;Integrated Security=True;User Instance=True";
            int k = GenerateQuestionNumber();
            SqlCommand cmd = new SqlCommand(sqlStr, connection);
            try
            {
                GenerateTryBlockForQuestions(connection, cmd, k);
            }
            catch (Exception e)
            {
                tbQuestion.Text = e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
        private void PopolniPrasanje2()
        {
            string sqlStr = "SELECT * FROM Level2";
            SqlConnection connection = new SqlConnection();
            string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DataBase\Questions.mdf;Integrated Security=True;User Instance=True";
            int k = GenerateQuestionNumber();
            SqlCommand cmd = new SqlCommand(sqlStr, connection);
            try
            {
                GenerateTryBlockForQuestions(connection, cmd, k);              
            }
            catch (Exception e)
            {
                tbQuestion.Text = e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
        private void PopolniPrasanje3()
        {
            string sqlStr = "SELECT * FROM Level3";
            SqlConnection connection = new SqlConnection();
            string path = (Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DataBase\Questions.mdf;Integrated Security=True;User Instance=True";
            int k = GenerateQuestionNumber();
            SqlCommand cmd = new SqlCommand(sqlStr, connection);
            try
            {
                GenerateTryBlockForQuestions(connection, cmd, k);
            }
            catch (Exception e)
            {
                tbQuestion.Text = e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
        private void WrongAnswer()
        {
            WrongAnswerForm wrongform = new WrongAnswerForm(i, correctAnswer);
            wrongform.ShowDialog();
            isClosed = true;
            this.Close();
        }
        private void Find5050(string correctAnswer)
        {
            Answers = new List<int>();
            Answers.Add(1);
            Answers.Add(2);
            Answers.Add(3);
            Answers.Add(4);
            if (correctAnswer == btnAnswerA.Text) corrButton = 1;
            else if (correctAnswer == btnAnswerB.Text) corrButton = 2;
            else if (correctAnswer == btnAnswerC.Text) corrButton = 3;
            else if (correctAnswer == btnAnswerD.Text) corrButton = 4;
            Answers.RemoveAt(corrButton - 1);
            SecondAnswer5050 = random.Next(Answers.Count);
            for (int l = 0; l < Answers.Count; l++)
            {
                if (SecondAnswer5050 == l)
                {
                    SecondAnswer5050 = Answers[l];
                    break;
                }
            }
            HelperFunctFor5050(corrButton, SecondAnswer5050);
        }
        private void HelperFunctFor5050(int corrButton, int SecondAnswer5050)
        {
            if (corrButton != 1 && SecondAnswer5050 != 1)
            {
                btnAnswerA.Text = "";
                btnAnswerA.Enabled = false;
            }
            if (corrButton != 2 && SecondAnswer5050 != 2)
            {
                btnAnswerB.Text = "";
                btnAnswerB.Enabled = false;
            }
            if (corrButton != 3 && SecondAnswer5050 != 3)
            {
                btnAnswerC.Text = "";
                btnAnswerC.Enabled = false;
            }
            if (corrButton != 4 && SecondAnswer5050 != 4)
            {
                btnAnswerD.Text = "";
                btnAnswerD.Enabled = false;
            }
        }
        private void EnableButtons()
        {
            btnAnswerA.Enabled = true;
            btnAnswerB.Enabled = true;
            btnAnswerC.Enabled = true;
            btnAnswerD.Enabled = true;
            pbAskTheAudience.Enabled = true;
            pbCall.Enabled = true;
        }
        private void FindAnswerFromAudience(string correctAnswer)
        {
            int a = 0, b = 0, c = 0, d = 0; //procentite ke bidat ovie

            if (correctAnswer == btnAnswerA.Text)
                corrButton = 1;
            else if (correctAnswer == btnAnswerB.Text)
                corrButton = 2;
            else if (correctAnswer == btnAnswerC.Text)
                corrButton = 3;
            else if (correctAnswer == btnAnswerD.Text)
                corrButton = 4;
            if (i <= 5) // prvo nivo
            {
                if (corrButton == 1)
                {
                    a = random.Next(90, 101);
                    b = random.Next(0, 100 - a + 1);
                    c = random.Next(0, 100 - a - b + 1);
                    d = random.Next(0, 100 - b - a - c + 1);
                }
                else if (corrButton == 2)
                {
                    b = random.Next(90, 101);
                    a = random.Next(0, 100 - b + 1);
                    c = random.Next(0, 100 - b - a + 1);
                    d = random.Next(0, 100 - b - a - c + 1);
                }
                else if (corrButton == 3)
                {
                    c = random.Next(90, 101);
                    b = random.Next(0, 100 - c + 1);
                    a = random.Next(0, 100 - c - b + 1);
                    d = random.Next(0, 100 - c - b - a + 1);
                }
                else if (corrButton == 4)
                {
                    d = random.Next(90, 101);
                    b = random.Next(0, 100 - d + 1);
                    c = random.Next(0, 100 - d - b + 1);
                    a = random.Next(0, 100 - d - b - c + 1);
                }
            }
            else if (i <= 10)
            {
                if (corrButton == 1)
                {
                    a = random.Next(60, 81);
                    b = random.Next(0, 100 - a + 1);
                    c = random.Next(0, 100 - a - b + 1);
                    d = random.Next(0, 100 - a - b - c + 1);
                }
                else if (corrButton == 2)
                {
                    b = random.Next(60, 81);
                    a = random.Next(0, 100 - b + 1);
                    c = random.Next(0, 100 - b - a + 1);
                    d = random.Next(0, 100 - b - a - c + 1);
                }
                else if (corrButton == 3)
                {
                    c = random.Next(60, 81);
                    b = random.Next(0, 100 - c + 1);
                    a = random.Next(0, 100 - c - b + 1);
                    d = random.Next(0, 100 - c - b - a + 1);
                }
                else if (corrButton == 4)
                {
                    d = random.Next(60, 81);
                    b = random.Next(0, 100 - d + 1);
                    c = random.Next(0, 100 - d - b + 1);
                    a = random.Next(0, 100 - d - b - c + 1);
                }
            }
            else if (i <= 15)
            {
                a = random.Next(0, 50);
                b = random.Next(0, 100 - a + 1);
                c = random.Next(0, 100 - a - b + 1);
                d = random.Next(0, 100 - a - b - c + 1);
            }

            ChartForm chartform = new ChartForm(a, b, c, d);
            chartform.ShowDialog();
        }      
#endregion

        #region Buttons_Click

        #region A_B_C_D_buttons click
        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            //dodadeno!!!
            play.Stop();
            btnAnswerA.ForeColor = Color.Orange;
            FormFinalAnswer form = new FormFinalAnswer(i);
            if (form.ShowDialog().Equals(DialogResult.OK))
            {
                if (btnAnswerA.Text == correctAnswer)
                {
                    btnAnswerA.ForeColor = Color.Green;
                    if (i == 15)
                    {
                        WinnerForm winner = new WinnerForm();
                        winner.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Status form1 = new Status(i);
                        form1.ShowDialog();
                        i++;
                        PopolniPrasanje();
                    }
                }
                else
                {
                    WrongAnswer();
                }
            }
            else
            {
                play.PlayLooping();
            }
            btnAnswerA.ForeColor = Color.White;
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            //dodadeno!!!
            play.Stop();
            btnAnswerB.ForeColor = Color.Orange;
            FormFinalAnswer form = new FormFinalAnswer(i);
            if (form.ShowDialog().Equals(DialogResult.OK))
            {
                if (btnAnswerB.Text == correctAnswer)
                {
                    btnAnswerB.ForeColor = Color.Green;
                    if (i == 15)
                    {
                        WinnerForm winner = new WinnerForm();
                        winner.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Status form1 = new Status(i);
                        form1.ShowDialog();
                        i++;
                        PopolniPrasanje();
                    }
                }
                else
                {
                    WrongAnswer();
                }
            }
            else
            {
                play.PlayLooping();
            }
            btnAnswerB.ForeColor = Color.White;
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            //dodadeno!!!
            play.Stop();
            btnAnswerC.ForeColor = Color.Orange;
            FormFinalAnswer form = new FormFinalAnswer(i);
            if (form.ShowDialog().Equals(DialogResult.OK))
            {
                if (btnAnswerC.Text == correctAnswer)
                {
                    btnAnswerC.ForeColor = Color.Green;
                    if (i == 15)
                    {
                        WinnerForm winner = new WinnerForm();
                        winner.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Status form1 = new Status(i);
                        form1.ShowDialog();
                        i++;
                        PopolniPrasanje();
                    }
                }
                else
                {
                    WrongAnswer();
                }
            }
            else
            {
                play.PlayLooping();
            }
            btnAnswerC.ForeColor = Color.White;
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            //dodadeno!!!
            play.Stop();
            btnAnswerD.ForeColor = Color.Orange;
            FormFinalAnswer form = new FormFinalAnswer(i);
            if (form.ShowDialog().Equals(DialogResult.OK))
            {
                if (btnAnswerD.Text == correctAnswer)
                {
                    btnAnswerD.ForeColor = Color.Green;
                    if (i == 15)
                    {
                        WinnerForm winner = new WinnerForm();
                        winner.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Status form1 = new Status(i);
                        form1.ShowDialog();
                        i++;
                        PopolniPrasanje();
                    }
                }
                else
                {
                    WrongAnswer();
                }
            }
            else
            {
                play.PlayLooping();
            }
            btnAnswerD.ForeColor = Color.White;
        }
        #endregion

        #region Joker_buttons (Ask the audience, 50/50, Call a friend)
        private void pb5050_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Clicked_5050)
            {
                Find5050(correctAnswer);
                Clicked_5050 = true;
            }
            pb5050.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5050.Image = imageList1.Images[17];
            pbAskTheAudience.Enabled = false;
            pbCall.Enabled = false;
        }
        private void pbCall_Click(object sender, EventArgs e)
        {
            //dodadeno!!!
            play.Stop();
            if (!Clicked_phoneFriend)
            {
                CallForm callform = new CallForm(correctAnswer, btnAnswerA.Text, btnAnswerB.Text, btnAnswerC.Text, btnAnswerD.Text);
                callform.ShowDialog();
                Clicked_phoneFriend = true;
                play.PlayLooping();
            }
            pbCall.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCall.Image = imageList1.Images[26];
        }
        private void pbAskTheAudience_Click(object sender, EventArgs e)
        {
            play.Stop();
            if (!Clicked_audience)
            {
                FindAnswerFromAudience(correctAnswer);
                Clicked_audience = true;
                play.PlayLooping();

            }
            pbAskTheAudience.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAskTheAudience.Image = imageList1.Images[19];
        }
        #endregion

        private void pbOtkaziSe_Click(object sender, EventArgs e)
        {
            ExitForm form = new ExitForm(i);
            form.ShowDialog();
            isClosed = true;
            this.Close();
        }
       
        #endregion
    }
}
