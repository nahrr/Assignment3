using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Student
    {
        // Properties för Studentobjekt
        public string CourseModule { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public string Ssn { get; set; }
        public string GradeCanvas { get; set; }
        public string CourseCode { get; set; }
        
        // Mock-data för studenter
        public static List<Student> MadeUpStudents =>
            new List<Student>
            {
                new Student {
                    FirstName = "Kalle",
                    LastName = "Anka",
                    Ssn = "801010-1111",
                    StudentId = "kalank-1",
                    CourseCode = "D0032X",
                    CourseModule = "005",
                    GradeCanvas = "G"
                },

                new Student {
                    FirstName = "Kalle",
                    LastName = "Anka",
                    Ssn = "801010-1111",
                    StudentId = "kalank-1",
                    CourseCode = "D0032X",
                    CourseModule = "006",
                    GradeCanvas = "G"
                },

                new Student {
                    FirstName = "Kalle",
                    LastName = "Anka",
                    Ssn = "801010-1111",
                    StudentId = "kalank-1",
                    CourseCode = "D0032X",
                    CourseModule = "001",
                    GradeCanvas = "VG"
                },

                new Student {
                    FirstName = "Musse",
                    LastName = "Pigg",
                    Ssn = "838383-2222",
                    StudentId = "muspig-1",
                    CourseCode = "D0032X",
                    CourseModule = "005",
                    GradeCanvas = "VG"
                },

                new Student {
                    FirstName = "Musse",
                    LastName = "Pigg",
                    Ssn = "838383-2222",
                    StudentId = "muspig-1",
                    CourseCode = "D0032X",
                    CourseModule = "006",
                    GradeCanvas = "VG"
                },

                new Student {
                    FirstName = "Musse",
                    LastName = "Pigg",
                    Ssn = "838383-2222",
                    StudentId = "muspig-1",
                    CourseCode = "D0032X",
                    CourseModule = "001",
                    GradeCanvas = "VG"

                },

                new Student {
                    FirstName = "Gamma",
                    LastName = "Delta",
                    Ssn = "111111-2222",
                    StudentId = "gamdel-2",
                    CourseCode = "D0032X",
                    CourseModule = "006",
                    GradeCanvas = "U"
                },

                new Student {
                    FirstName = "Gamma",
                    LastName = "Delta",
                    Ssn = "111111-2222",
                    StudentId = "gamdel-2",
                    CourseCode = "D0032X",
                    CourseModule = "005",
                    GradeCanvas = "G"
                },

                new Student {
                    FirstName = "Gamma",
                    LastName = "Delta",
                    Ssn = "111111-2222",
                    StudentId = "gamdel-2",
                    CourseCode = "D0032X",
                    CourseModule = "001",
                    GradeCanvas = "G"
                },


                new Student {
                    FirstName = "Epsilon",
                    LastName = "Zeta",
                    Ssn = "222222-2222",
                    StudentId = "epszet-3",
                    CourseCode = "X0002X",
                    CourseModule = "005",
                    GradeCanvas = "VG"
                },

                new Student {
                    FirstName = "Epsilon",
                    LastName = "Zeta",
                    Ssn = "222222-2222",
                    StudentId = "epszet-3",
                    CourseCode = "X0002X",
                    CourseModule = "006",
                    GradeCanvas = "VG"
                },

                new Student {
                    FirstName = "Epsilon",
                    LastName = "Gamma",
                    Ssn = "3333333-3333",
                    StudentId = "epsgam-4",
                    CourseCode = "X0002X",
                    CourseModule = "005",
                    GradeCanvas = "G"
                },

                new Student {
                    FirstName = "Epsilon",
                    LastName = "Gamma",
                    Ssn = "3333333-3333",
                    StudentId = "epsgam-4",
                    CourseCode = "X0002X",
                    CourseModule = "006",
                    GradeCanvas = "U"
                }

            };

    }
}