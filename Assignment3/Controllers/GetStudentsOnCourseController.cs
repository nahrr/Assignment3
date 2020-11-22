using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class GetStudentsOnCourseController : ControllerBase
    {
        private readonly JAContext _context;

        public GetStudentsOnCourseController(JAContext context)
        {
            this._context = context;
        }

        [Route("{studentOnCourse}")]
        [HttpGet]
        public string GetStudentsByCourseCode(string studentOnCourse)
        {
            //var course = _context.Courses.FirstOrDefault(x => x.CourseCode.Equals(courseCode, StringComparison.InvariantCultureIgnoreCase));
                 var student = _context
                .Students
                .Include(x => x.Courses)
                .FirstOrDefault(x => x.CourseCode == studentOnCourse);


            return $"{string.Join(";", student.FirstName.Select(x => $"{x} ").ToArray())}";
            // return $"{string.Join(";", student.StudentId.Select(x => $"{x.} - {x.ModuleDesc}").ToArray())}";
            //return $"Kursid: {course.CourseId} Kursnamn: {course.CourseName} Kurskod: {course.CourseCode} Modul: {string.Join(", ", course.Modules.Select(x => $"{x.ModuleCode}").ToArray())}";
            /// return $"StudentID: {student.StudentId}  {string.Join(", ", student.Student.Select(x => $"{x.GradeCanvas}").ToArray())}"; 
        }

    }
}
