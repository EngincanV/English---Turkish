using PlanningGameV1.Data;
using System;
using System.Windows.Forms;

namespace PlanningGameV1
{
    public partial class AddWords : Form
    {
        public AddWords()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var ctx = new EnglishTurkishEntities1())
            {
                var trans = new translate()
                {
                    english = englishTxt.Text,
                    turkish = turkishTxt.Text,
                    type = typeTxt.Text,
                    sentence = sentenceTxt.Text
                };
                if (string.IsNullOrWhiteSpace(englishTxt.Text) || string.IsNullOrWhiteSpace(turkishTxt.Text) || string.IsNullOrWhiteSpace(typeTxt.Text) || string.IsNullOrWhiteSpace(sentenceTxt.Text))
                {
                    MessageBox.Show("You must fill in the all empty fields");
                }
                
                else
                {
                    ctx.translates.Add(trans);
                    ctx.SaveChanges();
                    status.Text="You inserted";
                }

            }
        }

        private void MBacklink_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

    }
}
