using System;
using System.Collections.Generic;

#nullable disable

namespace ExamsDL.Models
{
    public partial class ReliefReason
    {
        public ReliefReason()
        {
            ReliefUsers = new HashSet<ReliefUser>();
        }

        public int IdReliefReasons { get; set; }
        public string Reasons { get; set; }
        public int? IdRelief { get; set; }

        public virtual ICollection<ReliefUser> ReliefUsers { get; set; }
    }
}
