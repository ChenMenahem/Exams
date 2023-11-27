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
    public class EmployeesController : ControllerBase
    {
        IEmployeesRepository _EmployeessRepository = new EmployeesRepository();

        
        [HttpGet]
        [Route("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            return _EmployeessRepository.GetEmployees();
        }

        [HttpPost]
        [Route("addEmployee")]
        public bool AddEmployee(Employee employee)
        {
            bool isAddEmployee = _EmployeessRepository.AddEmployee(employee);
            return isAddEmployee;

        }
        [HttpDelete]
        [Route("RemoveEmployee/{EmployeeId}")]
        public bool RemoveEmployee(int EmployeeId)
        {


            bool isRemove = _EmployeessRepository.RemoveEmployee(EmployeeId);
            return isRemove;
        }

        [HttpPut]
        [Route("UpdateEmployee/{EmployeeId}")]
        public bool UpdateEmployee(int EmployeeId)
        {

            bool isUpdate = _EmployeessRepository.UpdateEmployee(EmployeeId);
            return isUpdate;
        }

    }
}