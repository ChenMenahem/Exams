using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IPersonalDetailesService
    {
        bool Add(PersonalDetaile personalDetaile);
        List<PersonalDetaile> GetAllPersonalDetails();
        PersonalDetaile GetAllPersonDetailsById(int iduser);
        bool Update(PersonalDetaile personalDetaile);
    }
}