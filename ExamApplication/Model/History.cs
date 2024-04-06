using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamApplication.Model
{
    [Table("History")]
    public class History
    {
        public int id { get; set; }
        public string studentname { get; set; }
        public string studentid { get; set; }
        public decimal score { get; set; }
        public DateTime time { get; set; }
        public int timetake { get; set; }
    }
}
