using System;
using System.Collections.Generic;

#nullable disable

namespace ExamsDL.Models
{
    public partial class Exam
    {
        public Exam()
        {
            ExamsUsers = new HashSet<ExamsUser>();
        }

        public int IdExam { get; set; }
        public DateTime Date { get; set; }
        public string Subjects { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Time { get; set; }
        public double Cost { get; set; }

        public virtual ICollection<ExamsUser> ExamsUsers { get; set; }
    }
}
