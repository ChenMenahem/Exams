using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IReliefTypesService
    {
        bool Add(ReliefType reliefType);
        void Dispose();
        List<ReliefType> GetTypesReasons();
        bool Remove(int Id_reliefType);
        bool Update(int Id_reliefType);
    }
}