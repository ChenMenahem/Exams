using ExamsDL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamsBL
{
    public interface IRelief_UsersRepository
    {
      public Task<bool> AddRealif_UserBL(ReliefUser Reliefuser);
        public Task<List<ReliefUser>> GetAllPersonReliefBL(int userId);
        public Task<List<ReliefReason>> GetallReliefReasonBL();
        public Task<List<ReliefType>> GetAllReliefTypeBL();
    }
}