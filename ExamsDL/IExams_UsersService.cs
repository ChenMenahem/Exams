using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IExams_UsersService
    {
        bool Add(ExamsUser examsUser);
        List<ExamsUser> GetAllExamsForUser(int userId);
    }
}