using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Entities
{
    public class Department
    {
        public int DeptId { get; set; }

        public string Name { get; set; }

        public DateTime YearOfCreation { get; set; }
    }
}
