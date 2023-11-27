using System;
using System.Collections.Generic;

#nullable disable

namespace ExamsDL.Models
{
    public partial class ReliefUser
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdReliefTypes { get; set; }
        public int IdReliefReasons { get; set; }
        public string ReliefExplanation { get; set; }
        public bool ReliefStatus { get; set; }
        public string ReliefFile { get; set; }

        public virtual ReliefReason IdReliefReasonsNavigation { get; set; }
        public virtual ReliefType IdReliefTypesNavigation { get; set; }
        public virtual PersonalDetaile IdUserNavigation { get; set; }
    }
}
