using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;

namespace ExamsDL
{
     public class EmployeesService : IEmployeesService
    {
        ExamsContext _examsContext = new ExamsContext();

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = _examsContext.Employees.ToList();
            return employees;
        }

        public bool Add(Employee employee)
        {
            try
            {

                _examsContext.Employees.Add(employee);
                _examsContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public bool Remove(int EmployeeID)
        {
            try
            {

                Employee currentEmployee = _examsContext.Employees.SingleOrDefault(item => item.Id == EmployeeID);
                _examsContext.Employees.Remove(currentEmployee);
                _examsContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(int EmployeeID)
        {
            try
            {

                Employee currentEmployee = _examsContext.Employees.SingleOrDefault(item => item.Id == EmployeeID);
                _examsContext.Employees.Update(currentEmployee);
                _examsContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
