using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Entities
{
    public enum Gender
    {
        Mail,
        Female
    }
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50,MinimumLength =5)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        [Range(18,60)]
        public int? Age { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public Gender Gender { get; set; }

      //  [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<EmployeeAddress>EmployeeAddresses { get; set; }

    }
}
