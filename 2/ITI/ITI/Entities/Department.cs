using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int InstructorId { get; set; }

        public Instructor Instructor { get; set; }

        public List<Student> Students { get; set; }

    }
}
