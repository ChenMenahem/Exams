using ExamsDL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamsDL
{
    public interface IRelief_UsersService
    {
        Task<bool> AddRealif(ReliefUser Reliefuser);
        Task<List<ReliefUser>> GetAllPersonRelief(int userId);
        Task<List<ReliefReason>> GetallReliefReason();
        Task<List<ReliefType>> GetAllReliefType();
    }
}