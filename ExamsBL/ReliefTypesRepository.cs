using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;

using ExamsDL;

namespace ExamsBL
{
   public class ReliefTypesRepository : IReliefTypesRepository
    {

        IReliefTypesService _ReliefTypesDL;

        public ReliefTypesRepository(ReliefTypesService ReliefTypesDL)
        {
            _ReliefTypesDL = ReliefTypesDL;
        }

        public ReliefTypesRepository()
        {
            _ReliefTypesDL = new ReliefTypesService();
        }

        public List<ReliefType> GetTypesReasons()
        {
            List<ReliefType> ReliefType = _ReliefTypesDL.GetTypesReasons();
            return ReliefType;
        }


        public bool AddReliefType(ReliefType Id_ReliefType)
        {
            bool isAdd = _ReliefTypesDL.Add(Id_ReliefType);
            return isAdd;
        }
        public bool RemoveIdReliefType(int Id_ReliefType)
        {
            bool isRemoveReliefType = _ReliefTypesDL.Remove(Id_ReliefType);
            return isRemoveReliefType;
        }
        public bool UpdateReliefType(int Id_ReliefType)
        {
            bool isUpdate_ReliefType = _ReliefTypesDL.Update(Id_ReliefType);
            return isUpdate_ReliefType;
        }
    }
}
