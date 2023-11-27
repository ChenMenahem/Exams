using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;


using ExamsDL;

namespace ExamsBL
{
    public class ExamsRepository : IExamsRepository1
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

        public List<Exam> GetExams()
        {
            List<Exam> exams = _ExamsDL.GetExams();
            return exams;
        }


        public bool AddExams(Exam Id_exam)
        {
            bool isAdd = _ExamsDL.Add(Id_exam);
            return isAdd;
        }
        public bool RemoveExam(int Id_exam)
        {
            bool isRemoveExam = _ExamsDL.Remove(Id_exam);
            return isRemoveExam;
        }
        public bool UpdateExam(int Id_exam)
        {
            bool isUpdateExam = _ExamsDL.Update(Id_exam);
            return isUpdateExam;
        }
    }
}
