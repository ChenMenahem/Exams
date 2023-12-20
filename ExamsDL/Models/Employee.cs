using System;
using System.Collections.Generic;

#nullable disable

namespace ExamsDL.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdPermissions { get; set; }

        public virtual Permission IdPermissionsNavigation { get; set; }
    }
}
