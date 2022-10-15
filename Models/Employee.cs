using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore.Models
{
    public partial class Employee
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the Employee Id")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name must consist of minimum 4 characters")]
        public string? EmpName { get; set; }
        [Required(ErrorMessage = "Enter the Employee Name")]
        public string? Designation { get; set; }
    }
}
