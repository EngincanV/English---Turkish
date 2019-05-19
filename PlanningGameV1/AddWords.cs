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

        public bool CheckSpaces(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var ctx = new EnglishTurkishEntities10())
            {
                var trans = new translate()
                {
                    english = englishTxt.Text,
                    turkish = turkishTxt.Text,
                    type = typeTxt.Text,
                    sentence = sentenceTxt.Text,
                    IsTrue = false,
                };
                if (CheckSpaces(trans.english) || CheckSpaces(trans.turkish) || CheckSpaces(trans.type) || CheckSpaces(trans.sentence))
                {
                    MessageBox.Show("You must fill in the all empty fields");
                }
                else
                {
                    ctx.translates.Add(trans);
                    ctx.SaveChanges();
                    status.Text="You inserted";
                    englishTxt.Text = "";
                    sentenceTxt.Text = "";
                    turkishTxt.Text = "";
                    typeTxt.Text = "";
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
