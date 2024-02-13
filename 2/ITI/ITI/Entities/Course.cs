using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Entities
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        public string Description { get; set; }

        public List<StudentCourse> StudentCoursees { get; set; }

        public List<CourseInstructor> InstructorCourses { get; set; }



    }
}
