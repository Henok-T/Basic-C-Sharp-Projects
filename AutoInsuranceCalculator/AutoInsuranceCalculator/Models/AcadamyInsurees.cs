using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoInsuranceCalculator.Models
{
    public class AcademyInsurees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Age { get; set; }
        public string CarYear { get; set; }
        public string CarModel { get; set; }
        public string CarMake { get; set; }
        public int Tickets { get; set; }
        public string DUI { get; set; }
        public string CoverageType { get; set; }
        public double Quote { get; set; }

        public void Add(AcademyInsurees entry)
        {
            return ;
        }
    }
}

