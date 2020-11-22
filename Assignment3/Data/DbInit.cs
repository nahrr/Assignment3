using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;

namespace Assignment3.Data
{
    public static class DbInit
    {
        public static void Initialize(JAContext context)
        {
            context.Database.EnsureCreated();


            // Look for any students.
            //if (context.Students.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //var students = new Student[]
            //{
            //    new Student{ID=1,FirstName="Kalle",LastName="Anka"},
            //    new Student{ID=2,FirstName="Musse",LastName="Pigg"},
            //    new Student{ID=3,FirstName="Janne",LastName="Långben"}
            //};

            //foreach (Student s in students)
            //{
            //    context.Students.Add(s);
            //}

            context.Courses.AddRange(Course.MadeUpCourses);
            context.Students.AddRange(Student.MadeUpStudents);
            //context.Modules.AddRange(Module.Modules);

            context.SaveChanges();
        }

    }
}
