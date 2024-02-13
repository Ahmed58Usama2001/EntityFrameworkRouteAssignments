using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Entities
{
    //EF supports 4 ways for mapping classes to database (Tables/Views)
    //1. By Convention (Default)
    //2. Data Annotation (Set of attributes that are used for data validation)
    //3. Fluent APIs ()
    //4. Configuration class per Entity

    //POCO Class
    //Plain Old CLR Object
    //public class Employee
    //{
    //    public int Id { get; set; } //Public numberic property with name (Id or EntityID : EmployeeId)=>Primary Key [Identity 1:1]

    //    public string Name { get; set; } //Reference type : Allow null
    //    public decimal Salary { get; set; } //Value type : Not allow null

    //    public int? Age { get; set; } //Value Type : Nullable==>allow null

    //}

    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength = 5)]
        // [MaxLength(50)]
        //   [MinLength(5)]
        public string Name { get; set; }

        //  [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }
        [Range(18, 60)]
        public int? Age { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
