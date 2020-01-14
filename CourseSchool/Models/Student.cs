using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeSchool.Models
{
    //Model Studenta wraz z walidacją.
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Podaj nazwisko.")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Podaj imię.")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Podaj datę.")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}