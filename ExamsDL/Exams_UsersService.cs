using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;

namespace ExamsDL
{
    public class Exams_UsersService : IExams_UsersService
    {
        ExamsContext _ExamsUser = new ExamsContext();


        public Exams_UsersService(ExamsContext examsUsers)
        {
            _ExamsUser = examsUsers;
        }


        public List<ExamsUser> GetAllExamsForUser(int userId)
        {
            List<ExamsUser> result = _ExamsUser.ExamsUsers
                 .Where(u => u.IdUser == userId)
                 .ToList();
            return result;
        }
        public List<ExamsUser> GetAllExams()
        {
            List<ExamsUser> result = _ExamsUser.ExamsUsers
                     .ToList();
            return result;
        }
        public bool Add(int idUser, int idExam)

        {
            _ExamsUser.ExamsUsers.Add(personalDetaile);
            _ExamsUser.SaveChanges();
            return true;
        }
    }
}