using ExamsDL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamsDL
{
    public interface IPersonalDetailesService
    {
        public List<PersonalDetaile> GetPersonalDetails();

        bool Add(PersonalDetaile personalDetaile);
        void Dispose();
       // List<PersonalDetaile> GetPersonalDetails();
        bool Remove(int Id_user);
        bool Update(int Id_user);
    }
}