using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Entities
{
    public class Department
    {
        public Department()
        {
            DateOfCreation = DateTime.Now;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfCreation { get; set; }

        public int ManagerId { get; set; }
        public Employee Manager { get; set; }


    }
}
