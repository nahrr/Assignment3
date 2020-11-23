using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
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
        public string RegisterResult(string ssn, string grade, string module, DateTime date, string courseCode)
        {
            var results = _context
                .LadokDb
                .Where(x => x.Ssn == ssn);

            var alreadyExists = false;
            foreach (var r in results)
            {
                if (r.Ssn.Equals(ssn) && r.Module.Equals(module) && r.CourseCode.Equals(courseCode))
                {
                    alreadyExists = true;

                    return $"Studenten finns redan registrerad för aktuell modul.";
                }
            }

            if (!alreadyExists)
            {
                var dbEntry = new Models.Ladok()
                {
                    Ssn = ssn,
                    Grade = grade,
                    Module = module,
                    Date = date,
                    CourseCode = courseCode
                };
                _context.Add(dbEntry);
                _context.SaveChanges();

                return $"Resultatet sparat i Ladok.";
            }
            return "invalid";
        }
    }
}
