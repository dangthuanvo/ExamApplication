using ExamApplication.Sẹrvice;
using System.Windows.Forms;

namespace ExamApplication.UI.Admin
{
    public partial class PasswordAsk : Form
    {
        SettingService settingservice = new SettingService();
        public PasswordAsk()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            all.innit.Hide();
            if (pass.Text == settingservice.Get().adminpassword)
            {
                Admin a = new Admin();
                a.ShowDialog();
                this.Close();
                all.innit.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu vui lòng thử lại");
                this.Close();
                all.innit.Show();
                //all.innit.Close();
            }
        }
    }
}
