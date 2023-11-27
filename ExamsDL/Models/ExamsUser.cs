using System;
using System.Collections.Generic;

#nullable disable

namespace ExamsDL.Models
{
    public partial class ExamsUser
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdExam { get; set; }
        public string IdFileStudy { get; set; }
        public string Class { get; set; }
        public string Grade { get; set; }
        public bool ExamsStatus { get; set; }
        public string NotesOffice { get; set; }
        public string NotesUser { get; set; }

        public virtual Exam IdExamNavigation { get; set; }
        public virtual PersonalDetaile IdUserNavigation { get; set; }
    }
}
