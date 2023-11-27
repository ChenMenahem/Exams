using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;

namespace ExamsDL
{
    public class ExsamsService : IExsamsService
    {
        ExamsContext _examsContext = new ExamsContext();

        public List<Exam> GetExams()
        {
            List<Exam> exams = _examsContext.Exams.ToList();
            return exams;
        }

        public bool Add(Exam exams)
        {
            try
            {

                _examsContext.Exams.Add(exams);
                _examsContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public bool Remove(int Id_exam)
        {
            try
            {

                Exam currentExam = _examsContext.Exams.SingleOrDefault(item => item.IdExam == Id_exam);
                _examsContext.Exams.Remove(currentExam);
                _examsContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(int IdExam)
        {
            try
            {

                Exam currentExam = _examsContext.Exams.SingleOrDefault(item => item.IdExam == IdExam);
                _examsContext.Exams.Update(currentExam);
                _examsContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

    