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

        public ExamsRepository(IExsamsService examDL)
        {
            _ExamsDL = examDL;
        }

        public ExamsRepository()
        {
            _ExamsDL = new ExsamsService();
        }

        public async Task<List<Exam>> GetExamsBl()
        {
            List<Exam> exams =  await _ExamsDL.GetExams();
            return exams;
        }
        public async Task<List<Exam>> GetAllPersonExamsBL(int Idexam)
        {
            List<Exam> relief =await _ExamsDL.GetAllPersonExams(Idexam);
            return relief;
        }



    }
}
