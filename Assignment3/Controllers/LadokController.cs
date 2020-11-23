using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    // Controller för Ladok - Simulerar Ladok API.

    [Route("api/[controller]")]
    [ApiController]
    public class LadokController : ControllerBase
    {

        private readonly JAContext _context;

        public LadokController(JAContext context)
        {
            this._context = context;
        }

        [Route("{studentSsn}/{gradeToLadok}/{module}/{date}/{course}")]
        [HttpGet]
        public string RegisterResult(string studentssn, string gradeToLadok, string module, DateTime date, string course)
        {
            var results = _context
                .LadokDb
                .Where(x => x.Ssn == studentssn);

            var alreadyExists = false;
            foreach (var r in results)
            {
                if (r.Ssn.Equals(studentssn) && r.Module.Equals(module) && r.CourseCode.Equals(course))
                {
                    alreadyExists = true;

                    return $"Studenten finns redan registrerad för aktuell modul.";
                }
            }

            if (!alreadyExists)
            {
                var dbEntry = new Models.Ladok()
                {
                    
                    Ssn = studentssn,
                    Grade = gradeToLadok,
                    Module = module,
                    Date = date,
                    CourseCode = course
                };
                _context.Add(dbEntry);
                _context.SaveChanges();

                return $"Resultatet sparat i Ladok.";
            }
            return "invalid";
        }
    }
}
