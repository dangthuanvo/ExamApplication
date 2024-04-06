using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Student
{
    public partial class StartExamExample : Form
    {
        public StartExamExample()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            all.isExample = true;
            (this.ParentForm as Student).loadform(new Exam(), "BÀI THI THỬ ĐANG DIỄN RA");
        }
    }
}
