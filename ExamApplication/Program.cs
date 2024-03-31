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
    }
}
