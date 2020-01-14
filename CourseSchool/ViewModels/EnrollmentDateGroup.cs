using System;
using System.ComponentModel.DataAnnotations;

namespace HomeSchool.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }

        public int TeacherCount { get; set; }
    }
}