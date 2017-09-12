using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tutor.Models
{
    public class TutorDBContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Tutor> Tutors { get; set; }
        DbSet<TutorType> TutorTypes { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Class> Classes { get; set; }
        DbSet<ClassRegistration> ClassRegistrations { get; set; }
        DbSet<Tuition> Tuitions { get; set; }
        DbSet<Major> Majors { get; set; }
        DbSet<Policy> Policies { get; set; }
        DbSet<Subject> Subjects { get; set; }

        public TutorDBContext() : base("name=TutorDBConnectionString") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Map(m =>
            {
                m.MapInheritedProperties(); 
            });

            modelBuilder.Entity<Tutor>().Map(m =>
            {
                m.MapInheritedProperties();
            });
        }
    }
}