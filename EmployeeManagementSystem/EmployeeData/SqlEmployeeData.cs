using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EmployeeData
{
    public class SqlEmployeeData : IEmployeeData
    {
        private EmployeeContext _employeeContext;
        public SqlEmployeeData(EmployeeContext employeeContext) {
            _employeeContext = employeeContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee= _employeeContext.Employees.Find(employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.ContactPreferences = employee.ContactPreferences;
                existingEmployee.Email = employee.Email;
                existingEmployee.PhoneNumber = employee.PhoneNumber;
                existingEmployee.DateofBirth = employee.DateofBirth;
                existingEmployee.Department = employee.Department;
                existingEmployee.IsActive = employee.IsActive;
                existingEmployee.PhotoPath = employee.PhotoPath;
                _employeeContext.Employees.Update(existingEmployee);
                _employeeContext.SaveChanges();
            }
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            //var employee = _employeeContext.Employees.Find(id);
            //return employee;
            return _employeeContext.Employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeContext.Employees.ToList();
        }
    }
}
