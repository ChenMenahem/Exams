using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IPersonalDetailesRepository
    {
        bool AddPersonalDelailesBL(PersonalDetaile Id_User);
        List<PersonalDetaile> GetAllPersonalDetailsBL();
        PersonalDetaile GetAllPersonDetailsByIdBl(int iduser);
        bool UpdatePersonalDetailesBL(PersonalDetaile Id_User);
    }
}