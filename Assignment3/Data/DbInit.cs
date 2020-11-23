using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.Data
{
    /*
     * Initierar och populerar databasen
     */
    public static class DbInit
    {
        public static void Initialize(JAContext context)
        {
            context.Database.EnsureCreated();

            context.Courses.AddRange(Course.MadeUpCourses);
            context.Students.AddRange(Student.MadeUpStudents);

            context.SaveChanges();
        }

    }
}
