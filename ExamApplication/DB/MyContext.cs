using ExamApplication.Model;
using System.Data.Entity;

namespace Web.Core.Service
{
    public class MyContext : DbContext
    {
        public static string connect = "workstation id=ExamApplication.mssql.somee.com;packet size=4096;user id=dangthuanvo_SQLLogin_1;pwd=yddt9lss29;data source=ExamApplication.mssql.somee.com;persist security info=False;initial catalog=ExamApplication;TrustServerCertificate=True";
        public MyContext() : base(connect)
        {
        }

        public virtual DbSet<ExamApplication.Model.Lecture> Lectures { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionExample> QuestionExamples { get; set; }

    }
}
