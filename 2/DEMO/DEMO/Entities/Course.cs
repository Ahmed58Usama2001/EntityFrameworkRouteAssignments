using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Entities
{
    public class Course
    {
        public int Id { get; set; }

        public string Tilte { get; set; }

        public List<Student> Students { get; set; }

    }
}
