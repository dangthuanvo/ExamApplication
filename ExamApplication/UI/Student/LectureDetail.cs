using ExamApplication.Sẹrvice;
using System.Windows.Forms;

namespace ExamApplication.UI.Student
{
    public partial class LectureDetail : Form
    {
        //ExamApplicationEntities1 db = new ExamApplicationEntities1();
        LectureService lectureservice = new LectureService();
        public LectureDetail()
        {
            InitializeComponent();
            //var lecture = db.Lectures.FirstOrDefault(l => l.name == all.selectedLecture);
            //lecturedetaildata.Rtf = lecture.data;
            lecturedetaildata.Rtf = lectureservice.GetByName(all.selectedLecture).data;
        }
    }
}
