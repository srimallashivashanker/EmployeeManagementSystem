using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ContactPreferences { get; set; }
        public string Email { get; set; }
        public Int64 PhoneNumber { get; set; }
        public string DateofBirth { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; }
        public string PhotoPath { get; set; }
    }
}
