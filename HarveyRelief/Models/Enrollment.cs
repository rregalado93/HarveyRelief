using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarveyRelief.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int VolunteerID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string DisasterType { get; set; }
        public virtual Volunteer Volunter { get; set; }
    }
}