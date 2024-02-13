using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    public class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Bonus { get; set; }

        public decimal Salary { get; set; }

        public decimal HourRate { get; set; }

        public string Address { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<CourseInstructor> CourseInstructors { get; set; }


    }
}
