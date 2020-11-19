using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        
        public List<Module> Modules { get; set; }

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
                            //ModuleId = 1,
                            ModuleCode = "005",
                            ModuleDesc = "Inlämningsuppgifter"
                        },
                        new Module
                        {
                            //ModuleId = 2,
                            ModuleCode = "006",
                            ModuleDesc = "Tentamen"
                        },
                        new Module
                        {
                            //ModuleId = 3,
                            ModuleCode = "001",
                            ModuleDesc = "Tentamen"
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
                            //ModuleId = 1,
                            ModuleCode = "005",
                            ModuleDesc = "Inlämningsuppgifter"
                        },
                        new Module
                        {
                            //ModuleId = 2,
                            ModuleCode = "006",
                            ModuleDesc = "Tentamen"
                        }
                    }
                }
            };

        public void GetList2()
        {
            // List<string> calledList = myClass.GetList();
            List<Course> DisplayCourses = Course.MadeUpCourses;
            ///More code here...
        }

        public List<Course> GetList()
        {
            return MadeUpCourses;
        }

    }       
}


