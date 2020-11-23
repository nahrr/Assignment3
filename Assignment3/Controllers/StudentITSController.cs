using System;
using System.Collections.Generic;
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
    public class StudentITSController : ControllerBase
    {

        private readonly JAContext _context;

        public StudentITSController (JAContext context)
        {
            this._context = context;
        }


        [Route("{studentId}")]
        [HttpGet]
        public string GetSsnByStudId(string studentId)
        {
            //var course = _context.Courses.FirstOrDefault(x => x.CourseCode.Equals(courseCode, StringComparison.InvariantCultureIgnoreCase));
            var student = _context
                .Students
                //.Include(x => x.StudentId)
                .FirstOrDefault(x => x.StudentId == studentId);

            return $"{student.Ssn}";
        }


    }
}
