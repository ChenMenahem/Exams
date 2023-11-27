using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IExamsRepository1
    {
        bool AddExams(Exam Id_exam);
        List<Exam> GetExams();
        bool RemoveExam(int Id_exam);
        bool UpdateExam(int Id_exam);
    }
}