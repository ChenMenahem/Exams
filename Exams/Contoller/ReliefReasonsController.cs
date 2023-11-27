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
    public class ReliefReasonsController : ControllerBase
    {
        IReliefReasonsRepository _ReliefReason = new ReliefReasonsRepository();


        [HttpGet]
        [Route("GetReliefReason")]
        public List<ReliefReason> GetReliefReason()
        {
            return _ReliefReason.GetIReliefReasons();
        }

        [HttpPost]
        [Route("addReliefReason")]
        public bool AddReliefReason(ReliefReason reliefReason)
        {
            bool isAddReliefReason = _ReliefReason.AddReliefReason(reliefReason);
            return isAddPersonalDetails;

        }
        [HttpDelete]
        [Route("RemovePersonalDetails/{PersonalId}")]
        public bool RemovePersonalDetails(int PersonalId)
        {


            bool isRemove = _PersonalDetails.RemovePersonalDetailes(PersonalId);
            return isRemove;
        }

        [HttpPut]
        [Route("UpdatePersonalDetail/{PersonalId}")]
        public bool UpdatePersonalDetail(int PersonalId)
        {

            bool isUpdate = _PersonalDetails.UpdatePersonalDetailes(PersonalId);
            return isUpdate;
        }
    }
}
