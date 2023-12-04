using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;


using ExamsDL;

namespace ExamsBL
{
    public class ExamsRepository : IExamsRepository
    {
        IExsamsService _ExamsDL;

        public ExamsRepository(ExsamsService examDL)
        {
            _ExamsDL = examDL;
        }

        public ExamsRepository()
        {
            _ExamsDL = new ExsamsService();
        }

        public List<Exam> GetExamsBl()
        {
            List<Exam> exams = _ExamsDL.GetExams();
            return exams;
        }
        public List<Exam> GetAllPersonExamsBL(int Idexam)
        {
            List<Exam> relief = _ExamsDL.GetAllPersonExams(Idexam);
            return relief;
        }



    }
}
