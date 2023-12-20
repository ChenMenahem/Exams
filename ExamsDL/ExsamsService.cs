using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;
using Microsoft.EntityFrameworkCore;
namespace ExamsDL
{
    public class ExsamsService : IExsamsService
    {
        ExamsContext _examsContext = new ExamsContext();

        public async Task<List<Exam>> GetExams()
        {
            List<Exam> result = await _examsContext.Exams
                 .ToListAsync();
            return result;
        }



        public async Task<List<Exam>> GetAllPersonExams(int Idexam)
        {
            List<Exam> result = await _examsContext.Exams
                 .Where(u => u.IdExam == Idexam)
                 .ToListAsync();
            return result;
        }


    }
}

    