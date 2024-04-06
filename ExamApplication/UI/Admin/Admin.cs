using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            loadform(new AdminAvatar(), "QUẢN TRỊ VIÊN");
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new LectureAdmin(), "SOẠN BÀI GIẢNG");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new Innit();
            a.ShowDialog();
            this.Close();
        }

        private void examButton_Click(object sender, EventArgs e)
        {
            loadform(new QuestionAdmin(), "SOẠN CÂU HỎI THI THẬT");
        }

        private void lectureButton_Click(object sender, EventArgs e)
        {
            loadform(new QuestionExampleAdmin(), "SOẠN CÂU HỎI THI THỬ");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadform(new Setting(), "CÀI ĐẶT");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            loadform(new StudentHistory(), "LỊCH SỬ SINH VIÊN LÀM BÀI THI");
        }
    }
}
