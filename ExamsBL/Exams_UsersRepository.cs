using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;


using ExamsDL;

namespace ExamsBL
{
    class Exams_UsersRepository 
    {
        IExams_UsersService _ExamsUsersDL;

        public Exams_UsersRepository(Exams_UsersService examUserDL)
        {
            _ExamsUsersDL = examUserDL;
        }

        public Exams_UsersRepository()
        {
            _ExamsUsersDL = new Exams_UsersService();
        }
        public List<ExamsUser> GetAllExamsBL()
        {
            List<ExamsUser> ExamsUser = _ExamsUsersDL.GetAllExams();
            return ExamsUser;
        }
        public List<ExamsUser> GetAllExamsForUserBL(int userId)
        {
            List<ExamsUser> ExamsForUser = _ExamsUsersDL.GetAllExamsForUser(userId);
            return ExamsForUser;
        }

    }
}
