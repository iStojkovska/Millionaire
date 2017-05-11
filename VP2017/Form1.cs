using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Configuration.Assemblies;
namespace VP2017
{
    public partial class Form1 : Form
    {
        string correctAnswer;
        int i;
        List<int> Pominati;
        int id;
        Point tbPointLocation;
        int corrButton;
        List<int> Answers;
        int SecondAnswer5050;
        bool Clicked_5050;
        public Form1()
        {
            InitializeComponent();
            corrButton = 0;
            BackgroundImageLayout = ImageLayout.Stretch;
            correctAnswer = "";
            i = 1;
            Pominati = new List<int>();
            int id=0;
            tbPointLocation = new Point();
            Answers = new List<int>();
            SecondAnswer5050 = 0;
            Clicked_5050 = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb5050.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5050.Image = imageList1.Images[16];
            pbAskTheAudience.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAskTheAudience.Image = imageList1.Images[18];
            pbCall.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCall.Image = imageList1.Images[25];
            pbQuestions.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuestions.Image = imageList1.Images[27];
            tbPointLocation = tbQuestion.Location;
            PopolniPrasanje();
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
            k = rand.Next(1, 5);
            while (Pominati.Contains(k) || k==4)
            {
                k = rand.Next(1, 5);
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
                    //Find5050(correctAnswer);

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
            k = rand.Next(1, 28);
            while (Pominati.Contains(k))
            {
                k = rand.Next(1, 28);
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

        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            //tbPointLocation = tbQuestion.Location;
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
            }
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
           // tbPointLocation = tbQuestion.Location;
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
            }
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
           // tbPointLocation = tbQuestion.Location;
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
            }
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            //tbPointLocation = tbQuestion.Location;
            //MessageBox.Show(tbPointLocation.X.ToString());
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
            }
        }

        private void tbQuestion_LocationChanged(object sender, EventArgs e)
        {
            tbPointLocation = tbQuestion.Location;
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
    }
}
