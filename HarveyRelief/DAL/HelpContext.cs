using HarveyRelief.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HarveyRelief.DAL
{
    public class HelpContext : DbContext
    {
        public HelpContext() : base("HelpContext")
        {

        }

        public DbSet<Volunteer> Volunteers { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}