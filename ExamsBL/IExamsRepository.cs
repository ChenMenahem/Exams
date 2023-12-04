using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IExamsRepository
    {
        List<Exam> GetAllPersonExamsBL(int Idexam);
        List<Exam> GetExamsBl();
    }
}