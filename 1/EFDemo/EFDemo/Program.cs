using EFDemo.Context;
using EFDemo.Entities;

class program
{
    static void Main(string[] args)
    {

        using(EnterpriseDbContext context=new EnterpriseDbContext())
        {
            #region insert
            //Employee employee = new Employee()
            //{
            //    Name = "Ahmed",
            //    Salary=5000,
            //    Age=22,
            //    Email="Ahmed@gmail.com",

            //};


            //Console.WriteLine(context.Entry(employee).State);  //Deattached

            //context.Add(employee);

            //Console.WriteLine(context.Entry(employee).State);  //Added

            //context.SaveChanges(); //connect to DB and commit all changes

            //Console.WriteLine(context.Entry(employee).State);  //unchanged

            #endregion

            #region Update

            var result = context.Employees.FirstOrDefault(Employee => Employee.EmpId == 1);
            result.Name = "Osama";

            //Console.WriteLine(context.Entry(result).State);  //Modified

            //context.SaveChanges(); //connect to DB and commit all changes

            //Console.WriteLine(context.Entry(result).State);  //unchanged

            #endregion

            #region Delete

            context.Remove(result);
            Console.WriteLine(context.Entry(result).State);  //deleted

            context.SaveChanges(); //connect to DB and commit all changes

            Console.WriteLine(context.Entry(result).State);  //deattached

            #endregion
        }
    }
}