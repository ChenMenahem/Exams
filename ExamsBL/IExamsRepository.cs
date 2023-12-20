using ExamsDL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamsBL
{
    public interface IExamsRepository
    {
        public Task<List<Exam>> GetExamsBl();
        public Task<List<Exam>> GetAllPersonExamsBL(int Idexam);
    }
}