using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;

namespace Assignment3
{
    public class ApiHandler
    {
        private readonly string _courseCode;
        private readonly string _courseModule;
        
 



        public ApiHandler(string courseModule, string courseCode)
        {
            _courseModule = courseModule;
            _courseCode = courseCode;

        }

        /// <summary>
        /// Tries to register result
        /// </summary>
        /// <returns>Result of registration</returns>
        private string ViewResult()
        {
            var result = ConnectToAPI("http://localhost:51526/api/GetCourse", $"?courseModule={_courseModule}&courseCode={_courseCode}")
                .Replace("\"", string.Empty); // Tar bort "" från svaret

            return result;

        }

        /// <summary>
        /// Conencts to an API and returns result
        /// </summary>
        /// <param name="url">URL of API</param>
        /// <param name="urlParameters">Parameters</param>
        /// <returns>Result or "invalid" if there's no response</returns>
        private string ConnectToAPI(string url, string urlParameters)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);

            var response = client.GetAsync(urlParameters).Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                return result; // Ska inte returnera, ska bara skriva in värde i _registrationCode

            }
            else
            {
                return "invalid";
            }
        }

    }
}
