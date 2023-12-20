using ExamsDL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamsBL
{
    public interface IPersonalDetailesRepository
    {
        Task<bool> AddPersonalDelailesBL(PersonalDetaile Id_User);
        Task<List<PersonalDetaile>> GetAllPersonalDetailsBL();
        Task<List<PersonalDetaile>> GetAllPersonDetailsByIdBl(int iduser);
        Task<bool> UpdatePersonalDetailesBL(PersonalDetaile Id_User);
    }
}