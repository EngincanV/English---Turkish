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
            EnglishTurkishEntities3 db = new EnglishTurkishEntities3();
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
                    MessageBox.Show("Başka Değer Yoktur Devam Etmek İçin Kelime Yerine Dönünüz");
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

        private void fetchBtn_Click(object sender, EventArgs e)
        {
            Kelimegetir();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            using (var db = new EnglishTurkishEntities3())
            {
                var sorgu = from a in db.translates.OrderBy(p => p.english) where a.id.ToString() == idTxt.Text select a;
                translateTxt.Text = translateTxt.Text.ToLower();
                foreach (var item in sorgu)
                {
                    if (translateTxt.Text==item.english.ToLower())
                    {
                        MessageBox.Show("Başarılı");
                        turkishTxt.Text = "";
                        translateTxt.Text = "";
                        vocabularyTxt.Text = "";
                        sentenceTxt.Text = "";
                        turkishTxt.Enabled = false;
                        translateTxt.Enabled = false;
                        item.IsTrue = true;
                    }
                    else
                    {
                        MessageBox.Show("Yanlış Kelime Girdiniz");
                        translateTxt.Enabled = false;
                        turkishTxt.Enabled = false;
                    }
                }
                db.SaveChanges();
            }
        }

        private void MBacklink_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
}
