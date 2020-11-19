using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{

    // <summary>description
    //Grade for the student
    //Added all possible content, maybe need to clean it up later
    //</summary>
    public class Student
    {
        public int CourseNumber { get; set; }
        public string CourseModule { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public string Ssn { get; set; }
        public string GradeCanvas { get; set; }
        public string ExamNumber { get; set; }
        public string Infomartion { get; set; }
        public string ExamDate { get; set; }
        public string GradeLadok { get; set; }
        public string Status { get; set; }

        public static List<Student> MadeUpStudents =>
            new List<Student>
            {
                new Student {
                FirstName = "Kalle",
                LastName = "Anka",
                Ssn = "801010-1111",
                StudentId = "kalank-1",
                }
            };


    }

}
