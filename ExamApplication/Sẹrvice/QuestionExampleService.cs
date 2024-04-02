using ExamApplication.DTO;
using System.Collections.Generic;
using System.Linq;
using Web.Core.Service;

namespace ExamApplication.Sẹrvice
{
    public class QuestionExampleService
    {
        public virtual List<QuestionExampleDTO> GetAll()
        {
            using (var context = new MyContext())
            {
                return context.QuestionExamples
                    .Select(x => new QuestionExampleDTO()
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
                    ExamApplication.Model.QuestionExample question = context.QuestionExamples.FirstOrDefault(x => x.question == key);

                    context.QuestionExamples.Remove(question);

                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }
        public virtual QuestionExampleDTO GetByName(string key)
        {
            using (var context = new MyContext())
            {
                return context.QuestionExamples
                    .Where(x => x.question == key)
                   .Select(x => new QuestionExampleDTO()
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
        public virtual QuestionExampleDTO Insert(QuestionExampleDTO entity)
        {
            using (var context = new MyContext())
            {
                ExamApplication.Model.QuestionExample question = new ExamApplication.Model.QuestionExample()
                {
                    question = entity.question,
                    A = entity.A,
                    B = entity.B,
                    C = entity.C,
                    D = entity.D,
                    correct_answer = entity.correct_answer,
                    isimportant = entity.isimportant,
                };
                context.QuestionExamples.Add(question);
                context.SaveChanges();

                return entity;
            }
        }
        public virtual void Update(int key, QuestionExampleDTO entity)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    ExamApplication.Model.QuestionExample question = context.QuestionExamples.FirstOrDefault(x => x.id == key);
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
