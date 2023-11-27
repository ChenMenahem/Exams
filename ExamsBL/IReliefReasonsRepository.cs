using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IReliefReasonsRepository
    {
        bool AddReliefReason(ReliefReason Id_ReliefReason);
        List<ReliefReason> GetIReliefReasons();
        bool RemoveIdReliefReason(int Id_ReliefReason);
        bool UpdateReliefReason(int Id_ReliefReason);
    }
}