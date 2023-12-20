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
    public class ExamsController : ControllerBase
    {
        IExamsRepository _ExamsRepository = new ExamsRepository();


        [HttpGet]
        [Route("GetExams")]
        public async Task<List<Exam>> GetExamsBl()
        {
            return await _ExamsRepository.GetExamsBl();
        }

        [HttpGet]
        [Route("GetExamsForUser")]
        public async Task<List<Exam>> GetAllExamsForUserBL(int userId)
        {
           
            return await _ExamsRepository.GetAllPersonExamsBL(userId);

        }
        
    }
}
    
