using DEMO.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Context
{
    internal class CompanyDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=. ; database=CompanyDbG01; trusted_connection=true;");
                
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Department>()
            //            .HasOne(dep => dep.Employee).WithOne(emp => emp.Department).HasForeignKey(nameof(Employee));

            modelBuilder.Entity<Department>()
                .HasOne(dep=>dep.Manager).WithOne()
                .HasForeignKey<Department>(dep=>dep.ManagerId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Employee>()
                .HasOne(emp => emp.Department)
                .WithOne()
                .HasForeignKey<Employee>(emp => emp.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Employee>()
                .HasMany(emp => emp.EmployeeAddresses);

            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }




    }
}
