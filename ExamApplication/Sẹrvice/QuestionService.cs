using ExamApplication.DTO;
using System.Collections.Generic;
using System.Linq;
using Web.Core.Service;

namespace ExamApplication.Sẹrvice
{
    public class Question
    {
        public virtual List<QuestionDTO> GetAll()
        {
            using (var context = new MyContext())
            {
                return context.Questions
                    .Select(x => new QuestionDTO()
                    {
                        id = x.id,
                        question = x.question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        correct_answer = x.correct_answer,
                        isimportant = x.isimportant,
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
                    ExamApplication.Model.Question question = context.Questions.FirstOrDefault(x => x.question == key);

                    context.Questions.Remove(question);

                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }
        public virtual QuestionDTO GetByName(string key)
        {
            using (var context = new MyContext())
            {
                return context.Questions
                    .Where(x => x.question == key)
                   .Select(x => new QuestionDTO()
                   {
                       id = x.id,
                       question = x.question,
                       A = x.A,
                       B = x.B,
                       C = x.C,
                       D = x.D,
                       correct_answer = x.correct_answer,
                       isimportant = x.isimportant
                   })
                   .FirstOrDefault();
            }
        }
        public virtual QuestionDTO Insert(QuestionDTO entity)
        {
            using (var context = new MyContext())
            {
                ExamApplication.Model.Question question = new ExamApplication.Model.Question()
                {
                    question = entity.question,
                    A = entity.A,
                    B = entity.B,
                    C = entity.C,
                    D = entity.D,
                    correct_answer = entity.correct_answer,
                    isimportant = entity.isimportant,
                };
                context.Questions.Add(question);
                context.SaveChanges();

                return entity;
            }
        }
        public virtual void Update(int key, QuestionDTO entity)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    ExamApplication.Model.Question question = context.Questions.FirstOrDefault(x => x.id == key);
                    question.question = entity.question;
                    question.A = entity.A;
                    question.B = entity.B;
                    question.C = entity.C;
                    question.D = entity.D;
                    question.correct_answer = entity.correct_answer;
                    question.isimportant = entity.isimportant;
                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }
    }
}
