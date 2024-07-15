using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class EmsDbContext : IdentityDbContext
    {
        public EmsDbContext(DbContextOptions<EmsDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        //seed some data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "HR" },
                new Department { Id = 3, Name = "Payroll" }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "John", Age = 30, Salary = 1000, DepartmentId = 1 },
                new Employee { Id = 2, Name = "Jane", Age = 25, Salary = 800, DepartmentId = 2 },
                new Employee { Id = 3, Name = "Doe", Age = 35, Salary = 1200, DepartmentId = 3 }
            );
        }
    }
}
