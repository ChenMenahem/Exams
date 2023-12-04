using ExamsDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsDL
{

    public class Relief_UsersService : IRelief_UsersService
    {
        ExamsContext _Relief = new ExamsContext();

        public Relief_UsersService(ExamsContext relief)
        {
            _Relief = relief;
        }

        public List<ReliefUser> GetAllPersonRelief(int userId)
        {
            List<ReliefUser> result = _Relief.ReliefUsers
                 .Where(u => u.IdUser == userId)
                 .ToList();
            return result;
        }
        public List<ReliefType> GetAllReliefType()
        {
            List<ReliefType> result = _Relief.ReliefTypes
                 .ToList();
            return result;
        }

        public List<ReliefReason> GetallReliefReason()
        {
            List<ReliefReason> result = _Relief.ReliefReasons
                 .ToList();
            return result;
        }

        public bool AddRealif(ReliefUser Reliefuser)
        {
            {
                _Relief.ReliefUsers.Add(Reliefuser);
                _Relief.SaveChanges();
                return true;
            }

        }
    }
}










   




