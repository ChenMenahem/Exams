using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;

namespace ExamsDL
{
   public class ReliefTypesService : IReliefTypesService
    {
        ExamsContext _reliefTypeContext = new ExamsContext();

        public List<ReliefType> GetTypesReasons()
        {
            List<ReliefType> reliefType = _reliefTypeContext.ReliefTypes.ToList();
            return reliefType;
        }

        public bool Add(ReliefType reliefType)
        {
            try
            {
                _reliefTypeContext.ReliefTypes.Add(reliefType);
                _reliefTypeContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public bool Remove(int Id_reliefType)
        {
            try
            {

                ReliefType currentReliefType = _reliefTypeContext.ReliefTypes.SingleOrDefault(item => item.IdRelifeTypes == Id_reliefType);
                _reliefTypeContext.ReliefTypes.Remove(currentReliefType);
                _reliefTypeContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(int Id_reliefType)
        {
            try
            {



                ReliefType currentReliefType = _reliefTypeContext.ReliefTypes.SingleOrDefault(item => item.IdRelifeTypes == Id_reliefType);
                _reliefTypeContext.ReliefTypes.Update(currentReliefType);
                _reliefTypeContext.SaveChanges();
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
