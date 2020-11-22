using System.Collections.Generic;

namespace Assignment3.Models
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleDesc { get; set; }
        public Course Course { get; set; }
   

        /*
        public static List<Module> Modules =>
            new List<Module>
            {
                new Module
                {
                    ModuleId = 1,
                    ModuleCode = "005",
                    ModuleDesc = "Inlämningsuppgifter",
                },
                new Module
                {
                    ModuleId = 2,
                    ModuleCode = "006",
                    ModuleDesc = "Tentamen",
                },
                new Module
                {
                    ModuleId = 3,
                    ModuleCode = "007",
                    ModuleDesc = "Tentamen Muntlig",
                }
            };*/
    }

}


