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
        public async Task<List<ReliefReason>> GetallReliefReasonBL()
        {
            return await _IRelief_UsersRepository.GetallReliefReasonBL();
        }
        [HttpGet]
        [Route("GetAllReliefType")]
        public async Task<List<ReliefType>> GetAllReliefTypeBL()
        {
            return await _IRelief_UsersRepository.GetAllReliefTypeBL();
        }

        [HttpGet]
        [Route("GetAllPersonRelief")]
        public async Task<List<ReliefUser>> GetAllPersonReliefBL(int userId)
        {
            return await _IRelief_UsersRepository.GetAllPersonReliefBL(userId);
        }
        [HttpPost]
        [Route("AddRealif_User")]
        public async Task<bool> AddRealif_UserBL(ReliefUser Reliefuser)
        {
            bool isAddPersonalDetails =await _IRelief_UsersRepository.AddRealif_UserBL(Reliefuser);
            return isAddPersonalDetails;
        }
    }
}
