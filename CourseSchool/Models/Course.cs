using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HomeSchool.Models;

namespace HomeSchool.Models
{
    public class Course
    {
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Id")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Nazwa")]
        public string Title { get; set; }

        [Range(0, 5)]
        [Display(Name = "Zaliczenia przedmiotu")]
        public int Credits { get; set; }
    }
}