using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseModule { get; set; }

        public Course(string coursecode, string coursename, string coursemodule)
        {
            CourseCode = coursecode;
            CourseName = coursename;
            CourseModule = coursemodule;
        }

        public static List<Course> MadeUpCourses =>
            new List<Course>
            {
                new Course ("1", "Economics", "Assignments"),
                new Course ("2", "History", "Assignments"),
                new Course ("3", "Math", "Assignments"),
                new Course ("4", "Web development", "Assignments"),
            };

    }
}
