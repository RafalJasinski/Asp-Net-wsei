using System.Collections.Generic;
using HomeSchool.Models;

namespace HomeSchool.ViewModels
{
    public class TeacherIndexData
    {
        public IEnumerable<Teacher> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}