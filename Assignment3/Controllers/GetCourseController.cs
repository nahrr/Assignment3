using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    [Produces("application/json")]
    [Route("api/ViewResults")]
    public class GetCourseController : Controller
    {
        private Dictionary<string, string> _courses; // fake db

        /// <summary>
        /// -------
        /// </summary>
        /// <param name="coursecode">Course</param>
        /// <param name="coursemodule">Term</param>
        /// <returns>-----</returns>
        [HttpGet]
        public string Get(string coursecode, string coursemodule)
        {
            InitializeDictionary();

            try
            {
                return _courses[coursecode] + $":{coursemodule}" ;
            }
            catch (Exception)
            {
                return "invalid";
            }
        }

        /// <summary>
        /// Initializes dictionary with courses and their registration code
        /// </summary>
        private void InitializeDictionary()
        {
            _courses = new Dictionary<string, string>
            {
                { "D0031N", "Inlämningsuppgifter" },
                { "D0023E", "Inlämningsuppgifter" },
                { "D0005N", "Inlämningsuppgifter" },
                { "D0006N", "Inlämningsuppgifter" },
                { "I0015N", "Inlämningsuppgifter" }
            };
        }

    }
       
}