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
    public class Relief_UsersController : ControllerBase
    {
        IRelief_UsersRepository _IRelief_UsersRepository = new Relief_UsersRepository();

        [HttpGet]
        [Route("GetallReliefReason")]
        public List<ReliefReason> GetallReliefReasonBL()
        {
            return _IRelief_UsersRepository.GetallReliefReasonBL();
        }
        [HttpGet]
        [Route("GetAllReliefType")]
        public List<ReliefType> GetAllReliefTypeBL()
        {
            return _IRelief_UsersRepository.GetAllReliefTypeBL();
        }

        [HttpGet]
        [Route("GetAllPersonRelief")]
        public List<ReliefUser> GetAllPersonReliefBL(int userId)
        {
            return _IRelief_UsersRepository.GetAllPersonReliefBL(userId);
        }
        [HttpPost]
        [Route("AddRealif_User")]
        public bool AddRealif_UserBL(ReliefUser Reliefuser)
        {
            bool isAddPersonalDetails = _IRelief_UsersRepository.AddRealif_UserBL(Reliefuser);
            return isAddPersonalDetails;
        }
    }
}
