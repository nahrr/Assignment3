using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Course
    {
        // Properties för Kursobjekt
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public List<Module> Modules { get; set; }

        //Mock-data för kurser (och moduler)
        public static List<Course> MadeUpCourses =>
            new List<Course>
            {
                new Course
                {
                    CourseCode = "D0032X",
                    CourseName = "Testkurs",
                    Modules = new List<Module>
                    {
                        new Module
                        {
                            ModuleCode = "005",
                            ModuleDesc = "Inlämningsuppgifter"
                        },
                        new Module
                        {
                            ModuleCode = "006",
                            ModuleDesc = "Tentamen"  
                        },
                        new Module
                        {
                            ModuleCode = "001",
                            ModuleDesc = "Projekt"
                        }
                    }
                },

                new Course
                {
                    CourseCode = "X0002X",
                    CourseName = "Testkurs2",
                    Modules = new List<Module>
                    {
                        new Module
                        {
                            ModuleCode = "005",
                            ModuleDesc = "Inlämningsuppgifter"
                        },
                        new Module
                        {
                            ModuleCode = "006",
                            ModuleDesc = "Tentamen"
                        }
                    }
                }
            };
    }
}


