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
    public class PermissionController : ControllerBase
    {
        IPersonalDetailesRepository _PersonalDetails= new PermissionRepository();


        [Route("GetPermission")]
        public List<Permission> GetPermission()
        {
        [HttpGet]
            return _ExamsPermission.GetPermissions();
        }

        [HttpPost]
        [Route("addExams")]
        public bool AddPermission(Permission permission)
        {
            bool isAddExam = _ExamsPermission.AddPermission(permission);
            return isAddExam;

        }
        [HttpDelete]
        [Route("RemovePermission/{PermissionId}")]
        public bool RemovePermission(int PermissionId)
        {


            bool isRemove = _ExamsPermission.RemovePermission(PermissionId);
            return isRemove;
        }

        [HttpPut]
        [Route("UpdatePermission/{PermissionId}")]
        public bool UpdatePermission(int PermissionId)
        {

            bool isUpdate = _ExamsPermission.UpdatePermission(PermissionId);
            return isUpdate;
        }

    }
}
