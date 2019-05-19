using PlanningGameV1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PlanningGameV1
{
    public partial class LearnWords : Form
    {
        public LearnWords()
        {
            InitializeComponent();
        }
        public void Kelimegetir()
        {
            Random rastgele = new Random();
            EnglishTurkishEntities10 db = new EnglishTurkishEntities10();
            translateTxt.Enabled = true;
            turkishTxt.Enabled = false;
            var count = (from a in db.translates select a).Count();
            int Id = rastgele.Next(0, count);
            var sorgu = from a in db.translates.OrderBy(p => p.english) where a.id == Id && a.IsTrue==false select a;
            int sayac = 0;
            foreach (var item in sorgu)
            {
                if (item.IsTrue==null)
                {
                    MessageBox.Show("There isn't other value, return to words section for continue");
                }
                if (item.IsTrue==true)
                {
                    break;
                }
                else if (item.IsTrue==false)
                {
                    turkishTxt.Text = item.turkish.ToString();
                    idTxt.Text = item.id.ToString();
                    //sentenceTxt.Text = item.sentence.ToString(); // Cümle Eklenecek
                    vocabularyTxt.Text = item.type.ToString();
                }
                sayac++;
            }
            if (sayac==0)
            {
                Kelimegetir();
            }
        }

        #region SqlClasses
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection conn; 
        #endregion

        private void fetchBtn_Click(object sender, EventArgs e)
        {
            Kelimegetir();
        }

        public void InsertData()
        {
            int count = 0;
            count++;
            try
            {
                string connectionString;

                connectionString =
                    @"Data Source=DESKTOP-5L02G6P\SQLEXPRESS;Initial Catalog=EnglishTurkish;Integrated Security=True";
                conn = new SqlConnection(connectionString);
                conn.Open();
                
                string sql = "INSERT INTO dbo.ranking(score, month, year) values(" + count + ", " + DateTime.Now.Month + ", " + DateTime.Now.Year + ")";
                command = new SqlCommand(sql, conn);
                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void QueryWords()
        {
            using (var db = new EnglishTurkishEntities10())
            {
                var sorgu = from a in db.translates.OrderBy(p => p.english) where a.id.ToString() == idTxt.Text select a;
                translateTxt.Text = translateTxt.Text.ToLower();
                foreach (var item in sorgu)
                {
                    if (translateTxt.Text == item.english.ToLower())
                    {
                        MessageBox.Show("Successfully!");
                        turkishTxt.Text ="";
                        translateTxt.Text = "";
                        vocabularyTxt.Text = "";
                        sentenceTxt.Text = "";
                        turkishTxt.Enabled = false;
                        translateTxt.Enabled = false;
                        item.IsTrue = true;
                    }
                    else
                    {
                        MessageBox.Show("You type a wrong word!");
                        translateTxt.Enabled = false;
                        turkishTxt.Enabled = false;
                    }

                    if (item.IsTrue == true)
                    {
                        InsertData();
                    }
                }
                db.SaveChanges();
            }
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            QueryWords();
        }

        private void MBacklink_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
}
