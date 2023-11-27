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
        IExamsRepository1 _ExamsRepository = new ExamsRepository();


        [HttpGet]
        [Route("GetExams")]
        public List<Exam> GetExams()
        {
            return _ExamsRepository.GetExams();
        }

        [HttpPost]
        [Route("addExams")]
        public bool AddExam(Exam exam)
        {
            bool isAddExam = _ExamsRepository.AddExams(exam);
            return isAddExam;

        }
        [HttpDelete]
        [Route("RemoveExam/{ExamId}")]
        public bool RemoveExam(int Examid)
        {


            bool isRemove = _ExamsRepository.RemoveExam(Examid);
            return isRemove;
        }

        [HttpPut]
        [Route("UpdateExam/{ExamId}")]
        public bool UpdateExam(int ExamId)
        {

            bool isUpdate = _ExamsRepository.UpdateExam(ExamId);
            return isUpdate;
        }

    }
}
    
