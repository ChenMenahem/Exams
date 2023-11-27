using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IReliefReasonsService
    {
        bool Add(ReliefReason reliefReason);
        void Dispose();
        List<ReliefReason> GetReliefReasons();
        bool Remove(int Id_reliefReason);
        bool Update(int Id_reliefReason);
    }
}