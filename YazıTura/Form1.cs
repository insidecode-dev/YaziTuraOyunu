using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazıTura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Yazı Tura oyunu";
        }
        public string[] questions = { "Yes", "No" };
        public string question = "";
        Random rand = new Random();
        DialogResult dialog;
        private void button1_guess_Click(object sender, EventArgs e)
        {
            do
            {
                question = questions[rand.Next(0, 2)];
                dialog = MessageBox.Show("Yazı mı ? Tura mı ? yazı=yes | tura=no", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            } while (dialog.ToString() != question);
            MessageBox.Show("You win !", "Congrats");
        }


    }
}
