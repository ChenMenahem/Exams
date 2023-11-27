using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;

namespace ExamsDL
{
    public class PersonalDetailesService : IPersonalDetailesService
    {
        ExamsContext _personalDetailsContext = new ExamsContext();
        public PersonalDetailesService(ExamsContext personalDetailsContext)
        {
            _personalDetailsContext = personalDetailsContext;
        }

        public  List<PersonalDetaile> GetPersonalDetails()
        {
            try
            {
                List<PersonalDetaile> personalDetails = _personalDetailsContext.PersonalDetailes.ToList();
                return personalDetails;
                    }

            catch(Exception ex)
            {
                return null;
            }

        }

        public bool Add(PersonalDetaile personalDetaile)
        {
            try
            {
                _personalDetailsContext.PersonalDetailes.Add(personalDetaile);
                _personalDetailsContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public bool Remove(int Id_user)
        {
            try
            {

                PersonalDetaile currentpersonalDetaile = _personalDetailsContext.PersonalDetailes.SingleOrDefault(item => item.IdUser == Id_user);
                _personalDetailsContext.PersonalDetailes.Remove(currentpersonalDetaile);
                _personalDetailsContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(int Id_user)
        {
            try
            {


                PersonalDetaile currentpersonalDetaile = _personalDetailsContext.PersonalDetailes.SingleOrDefault(item => item.IdUser == Id_user);
                _personalDetailsContext.PersonalDetailes.Update(currentpersonalDetaile);
                _personalDetailsContext.SaveChanges();
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
