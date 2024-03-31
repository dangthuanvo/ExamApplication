using ExamApplication.DTO;
using System.Collections.Generic;
using System.Linq;
using Web.Core.Service;

namespace ExamApplication.Sẹrvice
{
    public class LectureService
    {
        public virtual List<LectureDTO> GetAll()
        {
            using (var context = new MyContext())
            {
                return context.Lectures
                    .Select(x => new LectureDTO()
                    {
                        id = x.id,
                        name = x.name,
                        data = x.data,
                    })
                    .ToList();
            }
        }
        public virtual void DeleteByName(string key, string userSession = null)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    ExamApplication.Model.Lecture lecture = context.Lectures.FirstOrDefault(x => x.name == key);

                    context.Lectures.Remove(lecture);

                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }
        public virtual LectureDTO GetByName(string key)
        {
            using (var context = new MyContext())
            {
                return context.Lectures
                    .Where(x => x.name == key)
                   .Select(x => new LectureDTO()
                   {
                       id = x.id,
                       name = x.name,
                       data = x.data,
                   })
                   .FirstOrDefault();
            }
        }
        public virtual LectureDTO Insert(LectureDTO entity)
        {
            using (var context = new MyContext())
            {
                ExamApplication.Model.Lecture lecture = new ExamApplication.Model.Lecture()
                {
                    name = entity.name,
                    data = entity.data,
                };
                context.Lectures.Add(lecture);
                context.SaveChanges();

                return entity;
            }
        }
        public virtual void Update(int key, LectureDTO entity)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    ExamApplication.Model.Lecture lecture = context.Lectures.FirstOrDefault(x => x.id == key);
                    lecture.data = entity.data;
                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }
    }
}
