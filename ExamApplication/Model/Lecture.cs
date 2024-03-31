using System.ComponentModel.DataAnnotations.Schema;

namespace ExamApplication.Model
{
    [Table("Lecture")]
    public class Lecture
    {
        public int id { get; set; }
        public string name { get; set; }
        public string data { get; set; }
    }
}
