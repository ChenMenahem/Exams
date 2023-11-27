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


        public List<PersonalDetaile> GetPersonalDelailes()
        {
            List<PersonalDetaile> personalDetailes = _PersonalDetailsDL.GetPersonalDetails();
            return personalDetailes;
        }


        public bool AddPersonalDelailes(PersonalDetaile Id_User)
        {
            bool isAdd = _PersonalDetailsDL.Add(Id_User);
            return isAdd;
        }
        public bool RemovePersonalDetailes(int Id_User)
        {
            bool isRemovePersonalDetailes = _PersonalDetailsDL.Remove(Id_User);
            return isRemovePersonalDetailes;
        }
        public bool UpdatePersonalDetailes(int Id_User)
        {
            bool isUpdatePersonalDetailes = _PersonalDetailsDL.Update(Id_User);
            return isUpdatePersonalDetailes;
        }
    }

}

