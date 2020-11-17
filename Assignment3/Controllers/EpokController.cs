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
    [ApiController]
    public class EpokController : ControllerBase
    {
        private readonly JAContext _context;

        public EpokController(JAContext context)
        {
            this._context = context;
        }

        [Route("{courseCode}")]
        [HttpGet]
        public string GetModulesByCourseCode(string courseCode)
        {
            //var course = _context.Courses.FirstOrDefault(x => x.CourseCode.Equals(courseCode, StringComparison.InvariantCultureIgnoreCase));
            var course = _context
                .Courses
                .Include(x => x.Modules)
                .FirstOrDefault(x => x.CourseCode == courseCode);

            return $"Kursnamn: {course.CourseName} Kurskod: {course.CourseCode} Modul: {string.Join(", ", course.Modules.Select(x => $"{x.ModuleCode}").ToArray())}";
        }

    }
}
