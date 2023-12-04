using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IExams_UsersService
    {
        bool Add(int idUser, int idExam);
        List<ExamsUser> GetAllExams();
        List<ExamsUser> GetAllExamsForUser(int userId);
    }
}