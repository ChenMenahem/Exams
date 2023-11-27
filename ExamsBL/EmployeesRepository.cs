using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;


using ExamsDL;


namespace ExamsBL
{
    public class EmployeesRepository : IEmployeesRepository
    {
        IEmployeesService _EmployeeDL;

        public EmployeesRepository(EmployeesService employeeDL)
        {
            _EmployeeDL = employeeDL;
        }

        public EmployeesRepository()
        {
            _EmployeeDL = new EmployeesService();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = _EmployeeDL.GetEmployees();
            return employees;
        }


        public bool AddEmployee(Employee Id)
        {
            bool isAdd = _EmployeeDL.Add(Id);
            return isAdd;
        }
        public bool RemoveEmployee(int Id)
        {
            bool isRemoveEmployee = _EmployeeDL.Remove(Id);
            return isRemoveEmployee;
        }
        public bool UpdateEmployee(int Id)
        {
            bool isUpdateEmployee = _EmployeeDL.Update(Id);
            return isUpdateEmployee;
        }
    }
}
