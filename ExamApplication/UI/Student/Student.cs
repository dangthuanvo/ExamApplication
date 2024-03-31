using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Student
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void lectureButton_Click(object sender, EventArgs e)
        {
            title.Text = "BÀI GIẢNG";
            loadform(new Lecture());
        }

        private void examButton_Click(object sender, EventArgs e)
        {
            title.Text = "BÀI THI THỬ";
            //loadform(new ExampleExam());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            title.Text = "BÀI THI THỬ";
            loadform(new Exam());
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
