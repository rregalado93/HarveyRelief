using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HarveyRelief.Models;


namespace HarveyRelief.DAL
{
    public class HelpInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HelpContext>
    {
        protected override void Seed(HelpContext context)
        {
            var volunteers = new List<Volunteer>
            {
                new Volunteer{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Volunteer{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Volunteer{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")}
            };

            volunteers.ForEach(s => context.Volunteers.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment {VolunteerID=1, City="Houston", State="Texas", DisasterType="Hurricane" },
                new Enrollment {VolunteerID=1, City="Amarillo", State="Texas", DisasterType="Tornado" },
                new Enrollment {VolunteerID=2, City="Los Angeles", State="California", DisasterType="Earthquake" },
                new Enrollment {VolunteerID=3, City="Miami", State="Florida", DisasterType="Flood" }

            };

            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

        }

    }
}