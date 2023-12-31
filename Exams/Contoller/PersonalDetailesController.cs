﻿using Microsoft.AspNetCore.Http;
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
        [Route("GetAllPersonalDetails")]
        public async Task<List<PersonalDetaile>> GetAllPersonalDetailsBL()
        {
            return await _PersonalDetailsRepository.GetAllPersonalDetailsBL();
        }

        [HttpGet]
        [Route("GetAllPersonDetailsById")]

        public Task<List<PersonalDetaile>> GetAllPersonDetailsByIdBl(int iduser)
        {
            return  _PersonalDetailsRepository.GetAllPersonDetailsByIdBl( iduser);
        }


        [HttpPost]
        [Route("AddPersonalDelailes")]
        public async Task<bool> AddPersonalDelailesBL(PersonalDetaile Id_User)
        {
            bool isAddPersonalDetails =await  _PersonalDetailsRepository.AddPersonalDelailesBL(Id_User);
            return isAddPersonalDetails;

        }


        [HttpPut]
        [Route("UpdatePersonalDetail/{PersonalId}")]
        public async Task<bool> UpdatePersonalDetailesBL(PersonalDetaile Id_User)
        {

            bool isUpdate = await _PersonalDetailsRepository.UpdatePersonalDetailesBL(Id_User);
            return isUpdate;
        }
    }
}
