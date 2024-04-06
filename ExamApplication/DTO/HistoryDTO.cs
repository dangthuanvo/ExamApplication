using System;

namespace ExamApplication.DTO
{
    public class HistoryDTO
    {
        public int id { get; set; }
        public string studentname { get; set; }
        public string studentid { get; set; }
        public decimal score { get; set; }
        public DateTime time { get; set; }
        public int timetake { get; set; }
    }
}
