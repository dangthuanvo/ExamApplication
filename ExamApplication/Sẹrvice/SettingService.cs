using ExamApplication.DTO;
using System.Linq;
using Web.Core.Service;

namespace ExamApplication.Sẹrvice
{
    public class SettingService
    {
        public virtual void Update(SettingDTO entity)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    ExamApplication.Model.Setting setting = context.Settings.FirstOrDefault();
                    setting.adminpassword = entity.adminpassword;
                    setting.exampassword = entity.exampassword;
                    setting.studentamount = entity.studentamount;
                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }
        public SettingDTO Get()
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    var setting = new SettingDTO()
                    {
                        adminpassword = context.Settings.FirstOrDefault().adminpassword,
                        exampassword = context.Settings.FirstOrDefault().exampassword,
                        studentamount = context.Settings.FirstOrDefault().studentamount,
                    };
                    return setting;

                }
            }
        }
    }
}
