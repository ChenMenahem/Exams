using ExamsDL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamsDL
{
    public interface IExsamsService
    {
        Task<List<Exam>> GetAllPersonExams(int Idexam);
        Task<List<Exam>> GetExams();
    }
}