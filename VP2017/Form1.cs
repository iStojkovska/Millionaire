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
namespace VP2017
{
    public partial class Form1 : Form
    {
        string path = "1001000 music.wav";
        public SoundPlayer startSound;
        string correctAnswer;
        int i;
        List<int> Pominati;
        int id;
        int corrButton;
        List<int> Answers;
        int SecondAnswer5050;
        bool Clicked_5050;
        bool Clicked_audience;
        public bool isClosed;
        bool Clicked_phoneFriend;
        List<int> VrednostiABCD;
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
            isClosed = false;
            Clicked_phoneFriend = false;
            VrednostiABCD = new List<int>();
            startSound = new SoundPlayer(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startSound.PlayLooping();
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
            startSound.PlayLooping();
        }
        public void Find5050(string correctAnswer)
        {
            Answers= new List<int>();
            Answers.Add(1);
            Answers.Add(2);
            Answers.Add(3);
            Answers.Add(4);
            if (correctAnswer == btnAnswerA.Text) corrButton = 1;
            else if (correctAnswer == btnAnswerB.Text) corrButton = 2;
            else if (correctAnswer == btnAnswerC.Text) corrButton = 3;
            else if (correctAnswer == btnAnswerD.Text) corrButton = 4;
            Answers.RemoveAt(corrButton - 1);
            Random random = new Random();
            SecondAnswer5050 = random.Next(Answers.Count);
            for (int l = 0; l < Answers.Count; l++)
            {
                if (SecondAnswer5050 == l)
                {
                    SecondAnswer5050 = Answers[l];
                    break;
                }
            }
                
            if (corrButton != 1 && SecondAnswer5050 != 1) btnAnswerA.Text = "";
            if (corrButton != 2 && SecondAnswer5050 != 2) btnAnswerB.Text = "";
            if (corrButton != 3 && SecondAnswer5050 != 3) btnAnswerC.Text = "";
            if (corrButton != 4 && SecondAnswer5050 != 4) btnAnswerD.Text = "";
        }

        

        public void PopolniPrasanje()
        {
            if (i <= 5)
            {
                PopolniPrasanje1();
            }
            else if (i <= 10)
            {
                Pominati = new List<int>();
                PopolniPrasanje2();
            }
            else if (i <= 15)
            {
                Pominati = new List<int>();
                PopolniPrasanje3();
            }
            

        }
        private void PopolniPrasanje1()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mycon"].ConnectionString; ;
            int k = 0;
            Random rand = new Random();
            k = rand.Next(6, 38);
            while (Pominati.Contains(k))
            {
                k = rand.Next(6, 38);
            }
            Pominati.Add(k);
            string sqlStr = "SELECT * FROM Level1";
            SqlCommand cmd = new SqlCommand(sqlStr, connection);
            try
            {

                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

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
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mycon"].ConnectionString; ;
            int k = 0;
            Random rand = new Random();
            k = rand.Next(1, 28);
            while (Pominati.Contains(k))
            {
                k = rand.Next(1, 28);
            }
            Pominati.Add(k);
            string sqlStr = "SELECT * FROM Level2";
           SqlCommand cmd = new SqlCommand(sqlStr, connection);
            try
            {
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    id=(int)sdr["quest_id"];
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
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mycon"].ConnectionString; ;
            int k = 0;
            Random rand = new Random();
            k = rand.Next(1, 18);
            while (Pominati.Contains(k))
            {
                k = rand.Next(1, 18);
            }
            Pominati.Add(k);
            string sqlStr = "SELECT * FROM Level3";
            SqlCommand cmd = new SqlCommand(sqlStr, connection);

            try
            {
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
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
            catch (Exception e)
            {
                tbQuestion.Text = e.Message;
            }
            finally
            {
                connection.Close();
            }
        }


        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            FormFinalAnswer form = new FormFinalAnswer();
            if (form.ShowDialog().Equals(DialogResult.OK))
            {
                if (btnAnswerB.Text == correctAnswer)
                {
                    Status form1 = new Status(i);
                    form1.ShowDialog();
                    i++;
                    PopolniPrasanje();
                }
                else
                {
                    WrongAnswerForm wrongform = new WrongAnswerForm(i,correctAnswer);
                    wrongform.ShowDialog();
                    isClosed = true;
                    this.Close();
                }
            }
            startSound.PlayLooping();
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            FormFinalAnswer form = new FormFinalAnswer();
            if (form.ShowDialog().Equals(DialogResult.OK))
            {
                if (btnAnswerC.Text == correctAnswer)
                {
                    Status form1 = new Status(i);
                    form1.ShowDialog();
                    i++;
                    PopolniPrasanje();
                }
                else
                {
                    WrongAnswerForm wrongform = new WrongAnswerForm(i, correctAnswer);
                    wrongform.ShowDialog();
                    isClosed = true;
                    this.Close();
                }
            }
            startSound.PlayLooping();
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            FormFinalAnswer form = new FormFinalAnswer();
            if (form.ShowDialog().Equals(DialogResult.OK))
            {
                if (btnAnswerD.Text == correctAnswer)
                {
                    Status form1 = new Status(i);
                    form1.ShowDialog();
                    i++;
                    PopolniPrasanje();
                }
                else
                {
                    WrongAnswerForm wrongform = new WrongAnswerForm(i, correctAnswer);
                    wrongform.ShowDialog();
                    isClosed = true;
                    this.Close();
                }
            }
            startSound.PlayLooping();
        }


        private void pb5050_MouseClick(object sender, MouseEventArgs e)
        {

            if (!Clicked_5050)
            {
                Find5050(correctAnswer);
                Clicked_5050 = true;
            }
            
                pb5050.SizeMode = PictureBoxSizeMode.StretchImage;
                pb5050.Image = imageList1.Images[17];
        }

        private void pbCall_Click(object sender, EventArgs e)
        {
            if (!Clicked_phoneFriend)
            {
                CallForm callform = new CallForm(correctAnswer, btnAnswerA.Text, btnAnswerB.Text, btnAnswerC.Text, btnAnswerD.Text);
                callform.ShowDialog();
            }
            pbCall.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCall.Image = imageList1.Images[26];
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            startSound.Stop();
            isClosed = true;
        }

        private void pbAskTheAudience_Click(object sender, EventArgs e)
        {
            if (!Clicked_audience)
            {
                FindAnswerFromAudience(correctAnswer);
                Clicked_audience = true;
            }

            pbAskTheAudience.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAskTheAudience.Image = imageList1.Images[19];
        }

        private List<int> PopolniABCD(int a, int b, int c, int d, int granicaLevo, int granicaDesno)
        {
            Random rand = new Random();
            List<int> vrednosti = new List<int>();
            a = rand.Next(granicaLevo, granicaDesno);
            vrednosti.Add(a);
            b = rand.Next(0, 100 - a + 1);
            vrednosti.Add(b);
            c = rand.Next(0, 100 - a - b + 1);
            vrednosti.Add(c);
            d = rand.Next(0, 100 - a - b - c + 1);
            vrednosti.Add(d);
            return vrednosti;
        }

        private void FindAnswerFromAudience(string correctAnswer)
        {
            int a=0, b=0, c=0, d=0; //procentite ke bidat ovie
           
            if (correctAnswer == btnAnswerA.Text)
                corrButton = 1;
            else if (correctAnswer == btnAnswerB.Text)
                corrButton = 2;
            else if (correctAnswer == btnAnswerC.Text)
                corrButton = 3;
            else if (correctAnswer == btnAnswerD.Text)
                corrButton = 4;
            Random rand = new Random();
            if (i <= 5) // prvo nivo
            {
                if (corrButton == 1)
                {
                   // VrednostiABCD = PopolniABCD(a, b, c, d, 90, 101);
                    a = rand.Next(90, 101);
                    b = rand.Next(0, 100 - b + 1);
                    c = rand.Next(0, 100 - b - a + 1);
                    d = rand.Next(0, 100 - b - a - c + 1);
                }
                else if (corrButton == 2)
                {
                    //PopolniABCD(b, a, c, d, 90, 101);
                    b = rand.Next(90, 101);
                    a = rand.Next(0, 100 - b + 1);
                    c = rand.Next(0, 100 - b - a + 1);
                    d = rand.Next(0, 100 - b - a - c + 1);
                }
                else if (corrButton == 3)
                {
                    //PopolniABCD(c, b, a, d, 90, 101);
                    c = rand.Next(90, 101);
                    b = rand.Next(0, 100 - c + 1);
                    a = rand.Next(0, 100 - c - b + 1);
                    d = rand.Next(0, 100 - c - b - a + 1);
                }
                else if (corrButton == 4)
                {
                    //PopolniABCD(d, b, c, a, 90, 101);
                    d = rand.Next(90, 101);
                    b = rand.Next(0, 100 - d + 1);
                    c = rand.Next(0, 100 - d - b + 1);
                    a = rand.Next(0, 100 - d - b - c + 1);
                }
                
            }
            else if (i <= 10)
            {
                if (corrButton == 1)
                {
                    a = rand.Next(60, 81);
                    b = rand.Next(0, 100 - a + 1);
                    c = rand.Next(0, 100 - a - b + 1);
                    d = rand.Next(0, 100 - a - b - c + 1);
                }
                else if (corrButton == 2)
                {
                    b = rand.Next(60, 81);
                    a = rand.Next(0, 100 - b + 1);
                    c = rand.Next(0, 100 - b - a + 1);
                    d = rand.Next(0, 100 - b - a - c + 1);
                }
                else if (corrButton == 3)
                {
                    c = rand.Next(60, 81);
                    b = rand.Next(0, 100 - c + 1);
                    a = rand.Next(0, 100 - c - b + 1);
                    d = rand.Next(0, 100 - c - b - a + 1);
                }
                else if (corrButton == 4)
                {
                    d = rand.Next(60, 81);
                    b = rand.Next(0, 100 - d + 1);
                    c = rand.Next(0, 100 - d - b + 1);
                    a = rand.Next(0, 100 - d - b - c + 1);
                }
            }
            else if (i <= 15)
            {
                    a = rand.Next(0, 50);
                    b = rand.Next(0, 100 - a + 1);
                    c = rand.Next(0, 100 - a - b + 1);
                    d = rand.Next(0, 100 - a - b - c + 1);
            }

            ChartForm chartform = new ChartForm(a, b, c, d);
            chartform.ShowDialog();
        }

        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            FormFinalAnswer form = new FormFinalAnswer();
            if (form.ShowDialog().Equals(DialogResult.OK))
            {
                if (btnAnswerA.Text == correctAnswer)
                {
                    Status form1 = new Status(i);
                    form1.ShowDialog();
                    i++;
                    PopolniPrasanje();

                }
                else
                {
                    WrongAnswerForm wrongform = new WrongAnswerForm(i, correctAnswer);
                    wrongform.ShowDialog();
                    isClosed = true;
                    this.Close();
                }
            }
            startSound.PlayLooping();
                    
        }

        private void pbOtkaziSe_Click(object sender, EventArgs e)
        {
            ExitForm form = new ExitForm(i);
            form.ShowDialog();
            isClosed = true;
            this.Close();
        }
    }
}
