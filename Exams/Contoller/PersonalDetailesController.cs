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
    public class PersonalDetailesController : ControllerBase
    {
        IPersonalDetailesRepository _PersonalDetailsRepository = new PersonalDetailesRepository();


        [HttpGet]
        [Route("GePersonalDetails")]
        public List<PersonalDetaile> GetPersonalDetails()
        {
            return _PersonalDetailsRepository.GetPersonalDelailes();
        }

        [HttpPost]
        [Route("addPersonalDetails")]
        public bool AddPersonalDetails(PersonalDetaile personalDetaile)
        {
            bool isAddPersonalDetails = _PersonalDetailsRepository.AddPersonalDelailes(personalDetaile);
            return isAddPersonalDetails;

        }
        [HttpDelete]
        [Route("RemovePersonalDetails/{PersonalId}")]
        public bool RemovePersonalDetails(int PersonalId)
        {


            bool isRemove = _PersonalDetailsRepository.RemovePersonalDetailes(PersonalId);
            return isRemove;
        }

        [HttpPut]
        [Route("UpdatePersonalDetail/{PersonalId}")]
        public bool UpdatePersonalDetail(int PersonalId)
        {

            bool isUpdate = _PersonalDetailsRepository.UpdatePersonalDetailes(PersonalId);
            return isUpdate;
        }
    }
}
