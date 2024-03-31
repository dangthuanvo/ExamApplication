using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Admin
{
    public partial class Admin : Form
    {
        public Admin()
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            title.Text = "SOẠN BÀI GIẢNG";
            loadform(new LectureAdmin());
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
