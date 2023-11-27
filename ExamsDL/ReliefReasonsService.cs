using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;

namespace ExamsDL
{
    public class ReliefReasonsService : IReliefReasonsService
    {
        ExamsContext _reliefReasonContext = new ExamsContext();

        public List<ReliefReason> GetReliefReasons()
        {
            List<ReliefReason> reliefReason = _reliefReasonContext.ReliefReasons.ToList();
            return reliefReason;
        }

        public bool Add(ReliefReason reliefReason)
        {
            try
            {
                _reliefReasonContext.ReliefReasons.Add(reliefReason);
                _reliefReasonContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public bool Remove(int Id_reliefReason)
        {
            try
            {

                ReliefReason currentReliefReason = _reliefReasonContext.ReliefReasons.SingleOrDefault(item => item.IdReliefReasons == Id_reliefReason);
                _reliefReasonContext.ReliefReasons.Remove(currentReliefReason);
                _reliefReasonContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(int Id_reliefReason)
        {
            try
            {



                ReliefReason currentReliefReason = _reliefReasonContext.ReliefReasons.SingleOrDefault(item => item.IdReliefReasons == Id_reliefReason);
                _reliefReasonContext.ReliefReasons.Update(currentReliefReason);
                _reliefReasonContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}