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
    public partial class TryYourself : Form
    {
        public TryYourself()
        {
            InitializeComponent();
        }

        private void MBacklink_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
        double gunfarki;
        DateTime now = DateTime.Now;
        public void kelimegetir()
        {
            Random rastgele = new Random();
            EnglishTurkishEntities13 db = new EnglishTurkishEntities13();
            int ID = rastgele.Next(0 ,db.translates.Count());
            int sayac = 0;
            var sorgu = from a in db.translates.OrderByDescending(p => p.translateLevel) where a.translateLevel > 0 && a.id == ID select a;
            if(sorgu.Count()>0)
            {
                foreach(var item in sorgu)
                {
                    DateTime d = item.level1.Value;
                    TimeSpan kalan = now - d;
                    gunfarki = kalan.TotalDays;
                    if(item.IsTrue == null)
                        MessageBox.Show("baska kelime yoktur kelime ekleyin");
                    if (item.translateLevel == 0)
                        break;
                    else if(item.translateLevel == 1 && gunfarki >= 1)
                    {
                        Turkcetxbox.Text = item.turkish.ToString();
                        Filltxbox.Text = item.type.ToString();
                        Idtxt.Text = item.id.ToString();
                    }
                    else if (item.translateLevel == 2 && gunfarki >= 7)
                    {
                        Turkcetxbox.Text = item.turkish.ToString();
                        Filltxbox.Text = item.type.ToString();
                        Idtxt.Text = item.id.ToString();
                    }
                    else if (item.translateLevel == 3 && gunfarki >= 29)
                    {
                        Turkcetxbox.Text = item.turkish.ToString();
                        Filltxbox.Text = item.type.ToString();
                        Idtxt.Text = item.id.ToString();
                    }
                    else if (item.translateLevel == 4 && gunfarki >= 180)
                    {
                        Turkcetxbox.Text = item.turkish.ToString();
                        Filltxbox.Text = item.type.ToString();
                        Idtxt.Text = item.id.ToString();
                    }
                    else
                        MessageBox.Show("kelime kalmadi başka zaman tekrar deneyin");
                    sayac++;
                }
                if (sayac == 0)
                    kelimegetir();
            }
            else
            {
                MessageBox.Show("Kelime Yok Kelime Ögren");
            }
        }

        private void KelimeGetir_Click(object sender, EventArgs e)
        {
            kelimegetir();
        }

        private void KelimeSorgulabtn_Click(object sender, EventArgs e)
        {
            using(var db = new EnglishTurkishEntities13())
            {
                var sorgu = from a in db.translates.OrderBy(p => p.english) where a.id.ToString() == Idtxt.Text select a;
                Translatetxbox.Text = Translatetxbox.Text.ToLower();
                foreach(var item in sorgu)
                {
                    if(Translatetxbox.Text == item.english.ToLower() && item.translateLevel == 1)
                    {
                        MessageBox.Show("Başarılı İkinci Seviyeye Çıktı Kelime 1 Hafta Sonra Tekrar Sorulacak");
                        Turkcetxbox.Text = "";
                        Translatetxbox.Text = "";
                        Filltxbox.Text = "";
                        Translatetxbox.Enabled = false;
                        Turkcetxbox.Enabled = true;
                        item.IsTrue = true;
                        item.translateLevel = 2;
                        item.level2 = DateTime.Now;
                        break;
                    }
                    if (Translatetxbox.Text == item.english.ToLower() && item.translateLevel == 2)
                    {
                        MessageBox.Show("Başarılı İkinci Seviyeye Çıktı Kelime 1 Ay Sonra Tekrar Sorulacak");
                        Turkcetxbox.Text = "";
                        Translatetxbox.Text = "";
                        Filltxbox.Text = "";
                        Translatetxbox.Enabled = false;
                        Turkcetxbox.Enabled = true;
                        item.IsTrue = true;
                        item.translateLevel = 3;
                        item.level3 = DateTime.Now;
                        break;
                    }
                    if (Translatetxbox.Text == item.english.ToLower() && item.translateLevel == 3)
                    {
                        MessageBox.Show("Başarılı İkinci Seviyeye Çıktı Kelime 6 Ay Sonra Tekrar Sorulacak");
                        Turkcetxbox.Text = "";
                        Translatetxbox.Text = "";
                        Filltxbox.Text = "";
                        Translatetxbox.Enabled = false;
                        Turkcetxbox.Enabled = true;
                        item.IsTrue = true;
                        item.translateLevel = 4;
                        item.level4 = DateTime.Now;
                        break;
                    }
                    if (Translatetxbox.Text == item.english.ToLower() && item.translateLevel == 4)
                    {
                        Turkcetxbox.Text = "";
                        Translatetxbox.Text = "";
                        Filltxbox.Text = "";
                        Translatetxbox.Enabled = false;
                        Turkcetxbox.Enabled = true;
                        item.IsTrue = true;
                        MessageBox.Show("Kelimeyi tamamen Ögrendiniz Tebrikler");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Yanlış Kelime Girdiniz");
                        Translatetxbox.Enabled = false;
                        Turkcetxbox.Enabled = false;
                        item.translateLevel = null;
                        item.level1 = null;
                        item.level2 = null;
                        item.level3 = null;
                        item.level4 = null;
                        item.IsTrue = false;
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
