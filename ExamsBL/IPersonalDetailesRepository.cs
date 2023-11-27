using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IPersonalDetailesRepository
    {
      public  bool AddPersonalDelailes(PersonalDetaile Id_User);
        List<PersonalDetaile> GetPersonalDelailes();
        bool RemovePersonalDetailes(int Id_User);
        bool UpdatePersonalDetailes(int Id_User);
    }
}