using ExamApplication.Sẹrvice;
using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Admin
{
    public partial class Setting : Form
    {
        SettingService settingservice = new SettingService();
        public Setting()
        {
            InitializeComponent();
            adminpass.Text = settingservice.Get().adminpassword;
            exampass.Text = settingservice.Get().exampassword;
            studentamount.Text = settingservice.Get().studentamount.ToString();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            settingservice.Update(new DTO.SettingDTO() { adminpassword = adminpass.Text, exampassword = exampass.Text, studentamount = int.Parse(studentamount.Text) });
            MessageBox.Show("Lưu thành công");
        }
    }
}
