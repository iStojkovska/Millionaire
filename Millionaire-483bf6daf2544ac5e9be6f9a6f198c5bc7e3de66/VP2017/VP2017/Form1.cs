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
        public Form1()
        {
            InitializeComponent();
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb5050.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5050.Image = imageList1.Images[0];
            pbAskTheAudience.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAskTheAudience.Image = imageList1.Images[2];
            pbCall.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCall.Image = imageList1.Images[22];
            pbQuestions.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuestions.Image = imageList1.Images[24];

            PopolniPrasanje();
        }

        private void PopolniPrasanje()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mycon"].ConnectionString; ;
           string sqlStr = "SELECT * FROM Level1";
           SqlCommand cmd = new SqlCommand(sqlStr, connection);
            
            try
            {
               
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    
                    tbQuestion.Text = sdr["quest"].ToString();
                    btnAnswerA.Text = sdr["a"].ToString();
                    btnAnswerB.Text = sdr["b"].ToString();
                    btnAnswerC.Text = sdr["c"].ToString();
                    btnAnswerD.Text = sdr["d"].ToString();

                    break;
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

    }
}
