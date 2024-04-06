using ExamApplication.DTO;
using ExamApplication.Sẹrvice;
using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Admin
{
    public partial class LectureAdmin : Form
    {
        //ExamApplicationEntities1 db = new ExamApplicationEntities1();
        LectureService lectureservice = new LectureService();
        public LectureAdmin()
        {
            InitializeComponent();
            delButton.Visible = false;

        }
        private void flowLoad()
        {
            flowLecture.Controls.Clear();
            foreach (var lecture in lectureservice.GetAll())
            {
                var button = new Guna.UI2.WinForms.Guna2Button();
                button.Width = flowLecture.Width;
                button.Height = 45;
                button.Text = lecture.name;
                button.Click += Button_Click;
                flowLecture.Controls.Add(button);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var a = sender as Guna.UI2.WinForms.Guna2Button;
            var lecture = lectureservice.GetByName(a.Text);
            //var lecture = db.Lectures.FirstOrDefault(l => l.name == a.Text);
            lecturedata.Rtf = lecture.data;
            lecturename.Text = lecture.name;
            delButton.Visible = true;
        }
        private void saveLectureButton_Click(object sender, EventArgs e)
        {
            if (delButton.Visible == false)
            {
                //DB.Lecture a = new DB.Lecture();
                //a.name = lecturename.Text;
                //a.data = lecturedata.Rtf;
                //db.Lectures.Add(a);
                //db.SaveChanges();
                LectureDTO lecture = new LectureDTO()
                {
                    data = lecturedata.Rtf,
                    name = lecturename.Text
                };
                lectureservice.Insert(lecture);
                lecturedata.Rtf = null;
                lecturename.Text = null;
                MessageBox.Show("Lưu thành công");
                flowLoad();
            }
            else
            {
                //var lecture = db.Lectures.FirstOrDefault(l => l.name == lecturename.Text);
                //lecture.data = lecturedata.Rtf;
                //db.SaveChanges();
                var lecture = lectureservice.GetByName(lecturename.Text);
                var lectureupdate = new LectureDTO()
                {
                    data = lecturedata.Rtf,
                };
                lectureservice.Update(lecture.id, lectureupdate);
                lecturedata.Rtf = null;
                lecturename.Text = null;
                MessageBox.Show("Lưu thành công");
                flowLoad();
            }
        }

        private void lecturename_TextChanged(object sender, EventArgs e)
        {
            //var lecture = db.Lectures.FirstOrDefault(l => l.name == lecturename.Text);
            var lecture = lectureservice.GetByName(lecturename.Text);
            if (lecture == null)
            {
                delButton.Visible = false;
                lecturedata.Rtf = null;
            }
            else
            {
                delButton.Visible = true;
                lecturedata.Rtf = lecture.data;
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            //var lecture = db.Lectures.FirstOrDefault(l => l.name == lecturename.Text);
            //db.Lectures.Remove(lecture);
            //db.SaveChanges();
            lectureservice.DeleteByName(lecturename.Text);
            lecturedata.Rtf = null;
            lecturename.Text = null;
            MessageBox.Show("Xoá thành công");
            flowLoad();
        }
        private void LectureAdmin_Load(object sender, EventArgs e)
        {
            flowLoad();
        }
    }
}
