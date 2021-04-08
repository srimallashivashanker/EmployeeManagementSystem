using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EmployeeData
{
   public interface IEmployeeData
    {
        #region For Employee Crud Operations
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        Employee AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Employee EditEmployee(Employee employee);
        #endregion
    }
}
