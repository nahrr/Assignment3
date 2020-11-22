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

                    var student = _context
                   .Students
                   .Include(x => x.Courses)
                   .FirstOrDefault(x => x.CourseCode == studentOnCourse);


           /// return $"{string.Join(";", student.FirstName.Select(x => $"{x} ").ToArray())}";

             return $"Namn: {student.FirstName} "; 
        }

    }
}
