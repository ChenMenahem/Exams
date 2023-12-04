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
            List<Exam> result = _examsContext.Exams
                 .ToList();
            return result;
        }



        public List<Exam> GetAllPersonExams(int Idexam)
        {
            List<Exam> result = _examsContext.Exams
                 .Where(u => u.IdExam == Idexam)
                 .ToList();
            return result;
        }


    }
}

    