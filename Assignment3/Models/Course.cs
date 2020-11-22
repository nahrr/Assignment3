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
                            ModuleDesc = "Inlämningsuppgifter",
                            Students = new List<Student>
                            {
                                new Student {

                                    FirstName = "Kalle",
                                    LastName = "Anka",
                                    Ssn = "801010-1111",
                                    StudentId = "kalank-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "G"
                                },

                                new Student {

                                    FirstName = "Musse",
                                    LastName = "Pigg",
                                    Ssn = "838383-2222",
                                    StudentId = "muspig-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "VG"
                                },

                                new Student {
                                    FirstName = "Alfa",
                                    LastName = "Beta",
                                    Ssn = "817171-2222",
                                    StudentId = "alfbet-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "VG"
                                },

                                 new Student {
                                    FirstName = "Gamma",
                                    LastName = "Beta",
                                    Ssn = "812172-2222",
                                    StudentId = "gambet-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "VG"
                                }

                            },
                        },
                        new Module
                        {
                            //ModuleId = 2,
                            ModuleCode = "006",
                            ModuleDesc = "Tentamen",
                            Students = new List<Student>
                            {
                               new Student {

                                    FirstName = "Kalle",
                                    LastName = "Anka",
                                    Ssn = "801010-1111",
                                    StudentId = "kalank-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "G"
                                },

                                new Student {

                                    FirstName = "Musse",
                                    LastName = "Pigg",
                                    Ssn = "838383-2222",
                                    StudentId = "muspig-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "VG"
                                },

                                new Student {
                                    FirstName = "Alfa",
                                    LastName = "Beta",
                                    Ssn = "817171-2222",
                                    StudentId = "alfbet-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "VG"
                                },

                                 new Student {
                                    FirstName = "Gamma",
                                    LastName = "Beta",
                                    Ssn = "812172-2222",
                                    StudentId = "gambet-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "VG"
                                }
                            }
                        },
                        new Module
                        {
                            //ModuleId = 3,
                            ModuleCode = "001",
                            ModuleDesc = "Projekt",
                            Students = new List<Student>
                            {
                                 new Student {

                                    FirstName = "Kalle",
                                    LastName = "Anka",
                                    Ssn = "801010-1111",
                                    StudentId = "kalank-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "G"
                                },

                                new Student {

                                    FirstName = "Musse",
                                    LastName = "Pigg",
                                    Ssn = "838383-2222",
                                    StudentId = "muspig-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "VG"
                                },

                                new Student {
                                    FirstName = "Alfa",
                                    LastName = "Beta",
                                    Ssn = "817171-2222",
                                    StudentId = "alfbet-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "VG"
                                },

                                 new Student {
                                    FirstName = "Gamma",
                                    LastName = "Beta",
                                    Ssn = "812172-2222",
                                    StudentId = "gambet-1",
                                    CourseCode = "D0032X",
                                    GradeCanvas = "VG"
                                }
                            }
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
                            ModuleDesc = "Inlämningsuppgifter",
                            Students = new List<Student>
                            {
                                new Student {
                                    FirstName = "Epsilon",
                                    LastName = "Zeta",
                                    Ssn = "222222-2222",
                                    StudentId = "epszet-3",
                                    CourseCode = "X0002X"
                                    },

                                    new Student {
                                    FirstName = "Epsilon",
                                    LastName = "Gamma",
                                    Ssn = "3333333-3333",
                                    StudentId = "epsgam-4",
                                    CourseCode = "X0002X"
                                    }
                            }
                        },
                        new Module
                        {
                            //ModuleId = 2,
                            ModuleCode = "006",
                            ModuleDesc = "Tentamen",
                            Students = new List<Student>
                            {
                                new Student {
                                    FirstName = "Epsilon",
                                    LastName = "Zeta",
                                    Ssn = "222222-2222",
                                    StudentId = "epszet-3",
                                    CourseCode = "X0002X"
                                    },

                                    new Student {
                                    FirstName = "Epsilon",
                                    LastName = "Gamma",
                                    Ssn = "3333333-3333",
                                    StudentId = "epsgam-4",
                                    CourseCode = "X0002X"
                    }
                            }
                        }
                    }
                }
                    };
    }
}


