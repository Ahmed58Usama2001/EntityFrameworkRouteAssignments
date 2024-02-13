using ITI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Context
{
    public class ITIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=. ; database=ITIDbG01; trusted_connection=true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Department>()
                .HasOne(dep => dep.Instructor).WithOne()
                .HasForeignKey<Department>(dep => dep.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Instructor>()
                .HasOne(ins => ins.Department)
                .WithOne()
                .HasForeignKey<Instructor>(ins => ins.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StudentCourse>().HasKey(pk => new { pk.StudentId, pk.CourseId });

            modelBuilder.Entity<CourseInstructor>().HasKey(pk => new { pk.CourseId, pk.InstructorId });

            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
