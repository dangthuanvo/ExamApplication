using ExamApplication.UI.Admin;
using ExamApplication.UI.Student;
using System;
using System.Windows.Forms;
namespace ExamApplication
{
    public partial class Innit : Form
    {
        public Innit()
        {
            InitializeComponent();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //var a = new PasswordAsk();
            //.ShowDialog();
            this.Hide();
            var a = new Admin();
            a.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new Student();
            a.ShowDialog();
            this.Close();
        }
    }
}
