using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IEmployeesService
    {
        bool Add(Employee employee);
        void Dispose();
        List<Employee> GetEmployees();
        bool Remove(int EmployeeID);
        bool Update(int EmployeeID);
    }
}