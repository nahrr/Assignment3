using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    public class Ladok
    {
        // Properties för simulerad Ladok
        public string Ssn { get; set; }
        public string CourseCode { get; set; }
        public string Module { get; set; }
        public DateTime Date { get; set; }
        public string Grade { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LadokId { get; set; }

    }
}
