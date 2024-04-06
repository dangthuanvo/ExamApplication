using System;
using System.Windows.Forms;

namespace ExamApplication
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Innit());
        }
    }
    public static class all
    {
        public static string selectedLecture { get; set; }
        public static string currentStudentName { get; set; }
        public static string currentStudentId { get; set; }
        public static DateTime currenttime { get; set; }
        public static bool isExample { get; set; }
        public static Form innit { get; set; }
    }
}
