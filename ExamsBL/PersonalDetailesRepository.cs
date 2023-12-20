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

        public PersonalDetailesRepository(IPersonalDetailesService PersonalDetailsDL)
        {
            _PersonalDetailsDL = PersonalDetailsDL;
        }
        public PersonalDetailesRepository()
        {
            _PersonalDetailsDL = new PersonalDetailesService();
        }

        public async Task<List<PersonalDetaile>> GetAllPersonDetailsByIdBl(int iduser)
        {
            List<PersonalDetaile> currentUser = await _PersonalDetailsDL.GetAllPersonDetailsById(iduser);
            return currentUser;
        }
        public async Task<List<PersonalDetaile>> GetAllPersonalDetailsBL()
        {
            List<PersonalDetaile> personalsDetailes = await _PersonalDetailsDL.GetAllPersonalDetails();
            return personalsDetailes;
        }


        public async Task<bool> AddPersonalDelailesBL(PersonalDetaile Id_User)
        {
            bool isAddPersonalDetails = await _PersonalDetailsDL.Add(Id_User);
            return isAddPersonalDetails;
        }

        public async Task<bool> UpdatePersonalDetailesBL(PersonalDetaile Id_User)
        {
            bool isUpdatePersonalDetailes = await _PersonalDetailsDL.Update(Id_User);
            return isUpdatePersonalDetailes;
        }
    }

}

