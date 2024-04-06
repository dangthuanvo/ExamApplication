using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Student
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            loadform(new StudentAvatar(), "SINH VIÊN");
        }
        public void loadform(object Form, string tit)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            title.Text = tit;
            f.Show();
        }
        public void Settitle(string a)
        {
            title.Text = a;
        }
        private void lectureButton_Click(object sender, EventArgs e)
        {
            loadform(new Lecture(), "BÀI GIẢNG");
        }

        private void examButton_Click(object sender, EventArgs e)
        {
            loadform(new StartExamExample(), "LÀM BÀI THI THỬ");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new StartExam(), "LÀM BÀI THI");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new Innit();
            a.ShowDialog();
            this.Close();
        }
    }
}
