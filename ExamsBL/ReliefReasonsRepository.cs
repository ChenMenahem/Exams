using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;

using ExamsDL;

namespace ExamsBL
{
    public class ReliefReasonsRepository : IReliefReasonsRepository
    {
        IReliefReasonsService _ReliefReasonsDL;

        public ReliefReasonsRepository(ReliefReasonsService ReliefReasonsDL)
        {
            _ReliefReasonsDL = ReliefReasonsDL;
        }

        public ReliefReasonsRepository()
        {
            _ReliefReasonsDL = new ReliefReasonsService();
        }

        public List<ReliefReason> GetIReliefReasons()
        {
            List<ReliefReason> ReliefReason = _ReliefReasonsDL.GetReliefReasons();
            return ReliefReason;
        }


        public bool AddReliefReason(ReliefReason Id_ReliefReason)
        {
            bool isAdd = _ReliefReasonsDL.Add(Id_ReliefReason);
            return isAdd;
        }
        public bool RemoveIdReliefReason(int Id_ReliefReason)
        {
            bool isRemoveReliefReason = _ReliefReasonsDL.Remove(Id_ReliefReason);
            return isRemoveReliefReason;
        }
        public bool UpdateReliefReason(int Id_ReliefReason)
        {
            bool isUpdate_ReliefReasons = _ReliefReasonsDL.Update(Id_ReliefReason);
            return isUpdate_ReliefReasons;
        }
    }
}
