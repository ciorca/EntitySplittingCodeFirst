using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Configuration;

namespace EntitySplittingCodeFirst
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                  .Map(map =>
                  {
                      map.Properties(p => new
                      {
                          p.EmployeeId,
                          p.FirstName,
                          p.LastName,
                          p.Gender
                      });
                      map.ToTable("Employees");
                  })
                      .Map(map =>
                       {
                           map.Properties(p => new
                           {
                               p.EmployeeId,
                               p.Email,
                               p.Mobile,
                               p.LandLine
                           });
                           map.ToTable("Employee.ContactDetails");
                       });
            base.OnModelCreating(modelBuilder);
        }

    }
}