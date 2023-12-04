using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;

using ExamsDL;

namespace ExamsBL
{
    public class Relief_UsersRepository : IRelief_UsersRepository
    {
        IRelief_UsersService _ReliefDL;

        public Relief_UsersRepository(Relief_UsersService ReliefDL)
        {
            _ReliefDL = ReliefDL;
        }

        public Relief_UsersRepository()
        {
            _ReliefDL = new Relief_UsersService();
        }


        public List<ReliefUser> GetAllPersonReliefBL(int userId)
        {
            List<ReliefUser> relief = _ReliefDL.GetAllPersonRelief(userId);
            return relief;
        }
        public List<ReliefType> GetAllReliefTypeBL()
        {
            List<ReliefType> reliefType = _ReliefDL.GetAllReliefType();
            return reliefType;
        }
        public List<ReliefReason> GetallReliefReasonBL()
        {
            List<ReliefReason> reliefReason = _ReliefDL.GetallReliefReason();
            return reliefReason;
        }
        public bool AddRealif_UserBL(ReliefUser Reliefuser)
        {
            bool isAdd = _ReliefDL.AddRealif_User(Reliefuser);
            return isAdd;
        }
    }
}
