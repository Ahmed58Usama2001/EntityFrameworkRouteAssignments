using EFDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Context
{
    public class EnterpriseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Ahmed; database=EnterpriseDb; trusted_Connection=true;");
           // optionsBuilder.UseSqlServer("data source=Ahmed; initial catalog=EnterpriseDb; integrated security=true;");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Department>().HasKey(d => d.DeptId);

            //modelBuilder.Entity<Department>().Property(nameof(Department.DeptId))
            //                                  .UseIdentityColumn(10,10);

            //modelBuilder.Entity<Department>().Property(d => d.Name)
            //                                  .IsRequired()
            //                                  .HasColumnType("varchar")
            //                                  .HasMaxLength(50)
            //                                  .IsUnicode(false);

            //modelBuilder.Entity<Department>().Property(d => d.YearOfCreation)
            //                                  .HasDefaultValue(DateTime.Now);


            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

        }

        public DbSet<Employee>Employees {  get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
