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
        public List<Exam> GetExamsBl()
        {
            return _ExamsRepository.GetExamsBl();
        }

        [HttpGet]
        [Route("GetExamsForUser")]
        public List<Exam> GetAllExamsForUserBL(int userId)
        {
           
            return _ExamsRepository.GetAllPersonExamsBL(userId);

        }
        
    }
}
    
