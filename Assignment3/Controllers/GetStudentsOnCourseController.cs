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

        [Route("{courseCode}/{moduleCode}")]
        [HttpGet]
        public string GetStudentsByCourseCode(string courseCode, string moduleCode)
        {
            var course = _context
                .Courses
                .Include(x => x.Modules)
                .FirstOrDefault(x => x.CourseCode == courseCode);

            var module = course
                .Modules
                .FirstOrDefault(x => x.ModuleCode == moduleCode);

            var students = module
                .Students
                .ToList();

            return $"{string.Join(";", students.Select(x => $"{x.FirstName} {x.LastName}|{x.GradeCanvas}").ToArray())}";
        }
    }
}