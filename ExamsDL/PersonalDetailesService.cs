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
        ExamsContext _personalDetails = new ExamsContext();
        public PersonalDetailesService(ExamsContext personalDetailsContext)
        {
            _personalDetails = personalDetailsContext;
        }

        public PersonalDetaile GetAllPersonDetailsById(int iduser)
        {
            List<PersonalDetaile> personals = GetAllPersonalDetails();
            PersonalDetaile currentPersonal = new PersonalDetaile();
            foreach (var p in personals)
            {

                if (p.IdUser == iduser)
                    currentPersonal = p;
            }
            return currentPersonal;

        }
        public List<PersonalDetaile> GetAllPersonalDetails()
        {
            List<PersonalDetaile> result = _personalDetails.PersonalDetailes
                     .ToList();
            return result;
        }

        public bool Add(PersonalDetaile personalDetaile)

        {
            _personalDetails.PersonalDetailes.Add(personalDetaile);
            _personalDetails.SaveChanges();
            return true;
        }

        public bool Update(PersonalDetaile personalDetaile)

        {
            _personalDetails.PersonalDetailes.Update(personalDetaile);
            _personalDetails.SaveChanges();
            return true;
        }

    }
}
           
        
