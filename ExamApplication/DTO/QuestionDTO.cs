﻿

namespace ExamApplication.DTO
{

    public class QuestionDTO
    {
        public int id { get; set; }
        public string question { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string correct_answer { get; set; }
        public bool isimportant { get; set; }

    }
}
