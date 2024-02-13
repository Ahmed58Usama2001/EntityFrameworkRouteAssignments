using DEMO.Context;
using DEMO.Entities;
using Microsoft.EntityFrameworkCore;

class program
{
    static void Main()
    {

        using(ITIDbG01Context context =new ITIDbG01Context())
        {
            #region SQL Queries

            //1. Execute Select Statement=>fromsqlrow, fromsqlinterpolated
            //    var result = context.Courses.FromSqlRaw("select * from Courses").ToList();

            //var result = context.Courses.FromSqlInterpolated($"select * from Courses").ToList();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //2.Execute DML Query

            // context.Database.ExecuteSqlInterpolated($"update courses set Name='C#' ");


            #endregion

            #region Eager loading

            //var result=(from department in context.Departments.Include(x=>x.Instructor)
            //           select department).FirstOrDefault();

            //Console.WriteLine($"{result.Name} and {result.Instructor?.Name} ");

            //may cause n+1 query problem 

            #endregion

            #region Explicit loading

            //var result = (from department in context.Departments
            //              select department).FirstOrDefault();

            //context.Entry(result).Reference(x => x.Instructor).Load();

            //Console.WriteLine($"{result.Name} and {result.Instructor.Name} ");



            #endregion

            #region Remote vs Local

            context.Courses.Load();

            //if (context.Courses.Local.Any(x => x.Id == 1))
            //    Console.WriteLine("Course with Id 1 is loaded locally");
            //else
            //    Console.WriteLine("There were no courses loaded locally");

            #endregion

            #region JOIN

            //var result = context.Courses.Join(
            //    context.StudentCourses,
            //    Course => Course.Id,
            //    StudentCourse => StudentCourse.CourseId,
            //    (Course, StudentCourse) => new
            //    {
            //        CourseName = Course.Name,
            //        StudentCoursename = StudentCourse.Student.LastName
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region tracking vs no tracking

            var result=context.Courses.Where(course=>course.Id==1).AsNoTracking().FirstOrDefault();

            result.Name = "CSharp";

            context.SaveChanges();


            #endregion

        }

    }
}