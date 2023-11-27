using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IEmployeesRepository
    {
        bool AddEmployee(Employee Id);
        List<Employee> GetEmployees();
        bool RemoveEmployee(int Id);
        bool UpdateEmployee(int Id);
    }
}