using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IReliefTypesRepository
    {
        bool AddReliefType(ReliefType Id_ReliefType);
        List<ReliefType> GetTypesReasons();
        bool RemoveIdReliefType(int Id_ReliefType);
        bool UpdateReliefType(int Id_ReliefType);
    }
}