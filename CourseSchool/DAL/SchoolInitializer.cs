using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HomeSchool.Models;

namespace HomeSchool.DAL
{
    //Populacja bazy danych zmockowanymi danymi.
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Billy",LastName="McNees",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Jennifer",LastName="Washington",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Albert",LastName="Wallace",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ronald",LastName="Flores",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Joette",LastName="Figueroa",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Lyle",LastName="Minich",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Wendy",LastName="Rodriguez",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Jon",LastName="Mangual",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Kimberely",LastName="Hogan",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Thomas",LastName="Roberts",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Peter",LastName="Spears",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Joseph",LastName="Mitchell",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Nery",LastName="Haywood",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Donna",LastName="Montgomery",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Donald",LastName="Hare",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Caroline",LastName="Hall",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Larry",LastName="Delgado",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Jeffrey",LastName="Redmond",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Ruby",LastName="Kennedy",EnrollmentDate=DateTime.Parse("2005-09-01")},


            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemia",Credits=3,},
            new Course{CourseID=4022,Title="Biologia",Credits=3,},
            new Course{CourseID=4041,Title="Matematyka",Credits=3,},
            new Course{CourseID=1045,Title="Język angielski",Credits=4,},
            new Course{CourseID=3141,Title="Język polski",Credits=4,},
            new Course{CourseID=2021,Title="Geografia",Credits=3,},
            new Course{CourseID=2042,Title="Literatura powszechna",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.C},
            new Enrollment{StudentID=7,CourseID=4022,Grade=Grade.D},
            new Enrollment{StudentID=8,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=8,CourseID=4022,Grade=Grade.A},
            new Enrollment{StudentID=8,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=9,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=9,CourseID=4022,Grade=Grade.A},
            new Enrollment{StudentID=10,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=10,CourseID=4022,Grade=Grade.A},
            new Enrollment{StudentID=11,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=11,CourseID=4022,Grade=Grade.A},
            new Enrollment{StudentID=11,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=11,CourseID=4022,Grade=Grade.A},
            new Enrollment{StudentID=12,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=12,CourseID=4022,Grade=Grade.A},
            new Enrollment{StudentID=12,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=13,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=14,CourseID=4022,Grade=Grade.A},
            new Enrollment{StudentID=14,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=14,CourseID=4022,Grade=Grade.A},
            new Enrollment{StudentID=15,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}