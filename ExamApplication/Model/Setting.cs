using System.ComponentModel.DataAnnotations.Schema;

namespace ExamApplication.Model
{
    [Table("Setting")]
    public class Setting
    {
        public int id { get; set; }
        public string adminpassword { get; set; }
        public string exampassword { get; set; }

        public int studentamount { get; set; }
    }
}
