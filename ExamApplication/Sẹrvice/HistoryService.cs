using ExamApplication.DTO;
using System.Collections.Generic;
using System.Linq;
using Web.Core.Service;

namespace ExamApplication.Sẹrvice
{
    public class HistoryService
    {
        public virtual List<HistoryDTO> GetAll()
        {
            using (var context = new MyContext())
            {
                return context.Histories
                    .Select(x => new HistoryDTO()
                    {
                        id = x.id,
                        studentid = x.studentid,
                        studentname = x.studentname,
                        time = x.time,
                        timetake = x.timetake,
                        score = x.score,
                    })
                    .ToList();
            }
        }
        public virtual HistoryDTO Insert(HistoryDTO entity)
        {
            using (var context = new MyContext())
            {
                ExamApplication.Model.History history = new ExamApplication.Model.History()
                {
                    studentid = entity.studentid,
                    studentname = entity.studentname,
                    time = entity.time,
                    timetake = entity.timetake,
                    score = entity.score,
                };
                context.Histories.Add(history);
                context.SaveChanges();

                return entity;
            }
        }
        public virtual bool GetById(string key)
        {
            using (var context = new MyContext())
            {
                if (context.Histories
                    .Where(x => x.studentid == key)
                   .Select(x => new HistoryDTO()
                   {
                       id = x.id,
                   })
                   .FirstOrDefault() != null)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public virtual void DeleteByName(string key, string userSession = null)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    ExamApplication.Model.History history = context.Histories.FirstOrDefault(x => x.studentid == key);

                    context.Histories.Remove(history);

                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }
        public virtual void Update(string key, decimal newscore, int newtime)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    ExamApplication.Model.History history = context.Histories.FirstOrDefault(x => x.studentid == key);
                    history.timetake = newtime;
                    history.score = newscore;
                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }
    }
}
