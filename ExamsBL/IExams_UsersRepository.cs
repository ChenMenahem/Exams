using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IExams_UsersRepository
    {
        bool Add(ExamsUser examsUser);
        List<ExamsUser> GetAllExamsForUserBL(int userId);
    }
}