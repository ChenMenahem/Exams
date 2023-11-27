using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IExsamsService
    {
        bool Add(Exam exams);
        void Dispose();
        List<Exam> GetExams();
        bool Remove(int Id_exam);
        bool Update(int IdExam);
    }
}