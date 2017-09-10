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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Map(m =>
            {
                m.MapInheritedProperties();
               
            });

             
        }
    }
}