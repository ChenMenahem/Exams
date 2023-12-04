using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;
using ExamsDL;
namespace ExamsBL
{
    public class PersonalDetailesRepository : IPersonalDetailesRepository
    {
        IPersonalDetailesService _PersonalDetailsDL;

        public PersonalDetailesRepository(PersonalDetailesService PersonalDetailsDL)
        {
            _PersonalDetailsDL = PersonalDetailsDL;
        }
        public PersonalDetailesRepository()
        {
            _PersonalDetailsDL = new PersonalDetailesService();
        }

        public PersonalDetaile GetAllPersonDetailsByIdBl(int iduser)
        {
            PersonalDetaile currentUser = _PersonalDetailsDL.GetAllPersonDetailsById(iduser);
            return currentUser;
        }
        public List<PersonalDetaile> GetAllPersonalDetailsBL()
        {
            List<PersonalDetaile> personalsDetailes = _PersonalDetailsDL.GetAllPersonalDetails();
            return personalsDetailes;
        }


        public bool AddPersonalDelailesBL(PersonalDetaile Id_User)
        {
            bool isAddPersonalDetails = _PersonalDetailsDL.Add(Id_User);
            return isAddPersonalDetails;
        }

        public bool UpdatePersonalDetailesBL(PersonalDetaile Id_User)
        {
            bool isUpdatePersonalDetailes = _PersonalDetailsDL.Update(Id_User);
            return isUpdatePersonalDetailes;
        }
    }

}

