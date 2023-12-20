using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamsDL.Models;

using ExamsBL;

namespace Exams.Contoller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Exams_UsersController : ControllerBase
    {
        IExams_UsersRepository _Exams_UserRepository = new Exams_UsersRepository();

        [HttpGet]
        [Route("GetExamsUsersID")]
        public List<ExamsUser> GetAllExamsForUserBL(int userId)
        {

            return _Exams_UserRepository.GetAllExamsForUserBL(userId);

        }

        [HttpPost]
        [Route("AddExamsUser")]
        public bool Add(ExamsUser Id_User)
        {
            bool AddExamUser = _Exams_UserRepository.Add(Id_User);
            return AddExamUser;

        }
    }
}
