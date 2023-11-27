using System;
using System.Collections.Generic;

#nullable disable

namespace ExamsDL.Models
{
    public partial class ReliefType
    {
        public ReliefType()
        {
            ReliefUsers = new HashSet<ReliefUser>();
        }

        public int IdRelifeTypes { get; set; }
        public string ReliefTypes { get; set; }

        public virtual ICollection<ReliefUser> ReliefUsers { get; set; }
    }
}
