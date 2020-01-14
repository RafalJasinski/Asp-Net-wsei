using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HomeSchool.Models;

namespace HomeSchool.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Teacher")]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Miejsce pracy")]
        public string Location { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}