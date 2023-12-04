using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IRelief_UsersRepository
    {
        bool AddRealif_UserBL(ReliefUser Reliefuser);
        List<ReliefUser> GetAllPersonReliefBL(int userId);
        List<ReliefReason> GetallReliefReasonBL();
        List<ReliefType> GetAllReliefTypeBL();
    }
}