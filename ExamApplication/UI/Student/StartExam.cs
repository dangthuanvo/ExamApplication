using ExamApplication.Sẹrvice;
using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Student
{
    public partial class StartExam : Form
    {
        SettingService settingservice = new SettingService();
        HistoryService historyservice = new HistoryService();
        public StartExam()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == null || idBox.Text == null || exampass.Text == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi bắt đầu bài thi");
            }
            else
            {
                if (int.Parse(idBox.Text) >= 1 && int.Parse(idBox.Text) <= settingservice.Get().studentamount)
                {
                    if (settingservice.Get().exampassword == exampass.Text)
                    {
                        if (!historyservice.GetById(idBox.Text))
                        {
                            all.currentStudentId = idBox.Text;
                            all.currentStudentName = nameBox.Text;
                            (this.ParentForm as Student).loadform(new Exam(), "BÀI THI ĐANG DIỄN RA");
                            all.currenttime = DateTime.Now;
                            all.isExample = false;
                        }
                        else
                        {
                            MessageBox.Show("Số thứ tự này đã làm bài thi rồi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu bài thi");
                    }
                }
                else
                {
                    MessageBox.Show("Số thự tự chỉ được trong khoảng từ 1 đến " + settingservice.Get().studentamount.ToString());
                }
            }
        }
    }
}
