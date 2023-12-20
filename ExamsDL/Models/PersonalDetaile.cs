using System;
using System.Collections.Generic;

#nullable disable

namespace ExamsDL.Models
{
    public partial class PersonalDetaile
    {
        public PersonalDetaile()
        {
            //ExamsUsers = new HashSet<ExamsUser>();
            //ReliefUsers = new HashSet<ReliefUser>();
        }

        public int IdUser { get; set; }
        public string IdentityNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int HouseNum { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UrlFilesId { get; set; }
        public string UserPassword { get; set; }

        //public virtual ICollection<ExamsUser> ExamsUsers { get; set; }
        //public virtual ICollection<ReliefUser> ReliefUsers { get; set; }
    }
}
