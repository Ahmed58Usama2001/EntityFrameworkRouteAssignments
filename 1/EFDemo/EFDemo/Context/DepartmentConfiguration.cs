using EFDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Context
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
       public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.DeptId);

            builder.Property(nameof(Department.DeptId)).UseIdentityColumn(10, 10);

            builder.Property(d => d.Name).IsRequired().HasColumnType("varchar").HasMaxLength(50).IsUnicode(false);

            builder.Property(d => d.YearOfCreation).HasDefaultValue(DateTime.Now);
        }
    }
}
