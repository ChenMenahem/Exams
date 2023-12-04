using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IExsamsService
    {
        List<Exam> GetAllPersonExams(int Idexam);
        List<Exam> GetExams();
    }
}