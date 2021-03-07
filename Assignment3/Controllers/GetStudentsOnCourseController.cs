using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Controllers
{

    // Controller för att få data från "simulerat Canvas". Returnerar namn och betyg på studenter aktuell kurs och modul.

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

        [Route("{courseCode}/{moduleCode}")]
        [HttpGet]
        public string GetStudentsByCourseCode(string courseCode, string moduleCode)
        {
            var students = _context
                .Students
                .Where(s => s.CourseCode.Equals(courseCode) && s.CourseModule.Equals(moduleCode))
                .ToList();

            return $"{string.Join(";", students.Select(x => $"{x.FirstName} {x.LastName}|{x.GradeCanvas}|{x.StudentId}").ToArray())}";
        }
    }
}