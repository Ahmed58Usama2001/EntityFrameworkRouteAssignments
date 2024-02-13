using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength = 5)]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength = 5)]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Range(18, 60)]
        [Required]
        public int Age { get; set; }

        public List<StudentCourse> CourseStudents { get; set; }

    }
}
