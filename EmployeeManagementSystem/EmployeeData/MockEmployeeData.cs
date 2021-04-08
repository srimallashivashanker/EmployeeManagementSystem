using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>() {
        new Employee(){
              Id= 1,
              Name= "Srimalla ShivaShanker",
              Gender= "Male",
              ContactPreferences= "Email",
              Email= "shivashanker909@gmail.com",
              DateofBirth= "04/07/1986",
              Department= "3",
              IsActive= true,
              PhotoPath="assets/images/Shiva.jpeg",
              PhoneNumber= 09866919092
        },
        new Employee(){
              Id= 2,
              Name= "Srimalla Rohansh Tej",
              Gender= "Male",
              ContactPreferences= "Email",
              Email= "srimallarohanshtej@gmail.com",
              DateofBirth= "01/03/2018",
              Department= "3",
              IsActive= true,
              PhotoPath="assets/images/Shiva.jpeg",
              PhoneNumber= 09866919092
        }
        };
        public Employee AddEmployee(Employee employee)
        {
            int id = 1; 
            employee.Id = id += 1;
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {

            var existingemployee = GetEmployee(employee.Id);
            existingemployee.Name = employee.Name;
            existingemployee.Gender = employee.Gender;
            existingemployee.ContactPreferences = employee.ContactPreferences;
            existingemployee.Email = employee.Email;
            existingemployee.PhoneNumber = employee.PhoneNumber;
            existingemployee.DateofBirth = employee.DateofBirth;
            existingemployee.Department = employee.Department;
            existingemployee.IsActive = employee.IsActive;
            existingemployee.PhotoPath = employee.PhotoPath;
            return existingemployee;

        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }
    }
}
