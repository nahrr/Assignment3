using System.Collections.Generic;

namespace Assignment3.Models
{
    public class Module
    {
        // Properties för Modultobjekt
        public int ModuleId { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleDesc { get; set; }
        public Course Course { get; set; }  
    }

}


