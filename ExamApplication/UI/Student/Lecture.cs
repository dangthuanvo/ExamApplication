
using ExamApplication.Sẹrvice;
using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Student
{
    public partial class Lecture : Form
    {
        //ExamApplicationEntities1 db = new ExamApplicationEntities1();
        LectureService lectureservice = new LectureService();
        public Lecture()
        {
            InitializeComponent();
            foreach (var lecture in lectureservice.GetAll())
            {
                var button = new Guna.UI2.WinForms.Guna2Button();
                button.Width = 640;
                button.Height = 45;
                button.Text = lecture.name;
                button.Click += Button_Click;
                flowLecture.Controls.Add(button);

            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var a = sender as Guna.UI2.WinForms.Guna2Button;
            all.selectedLecture = a.Text;
            (this.ParentForm as Student).loadform(new LectureDetail());
        }
    }
}
