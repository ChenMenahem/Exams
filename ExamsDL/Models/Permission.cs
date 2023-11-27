using System;
using System.Collections.Generic;

#nullable disable

namespace ExamsDL.Models
{
    public partial class Permission
    {
        public Permission()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdPermissions { get; set; }
        public string PermissionsName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
