using C44_G00_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G00_EF02.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasCheckConstraint("CK_Department_HiringDate", "HiringDate <= GETDATE()");

            D
                .HasOne(D => D.Manager)
                .WithOne(I => I.MangedDepartment)
                .HasForeignKey<Department>(D => D.Ins_ID)
                .OnDelete(DeleteBehavior.Restrict);

            D
                .HasMany(D=>D.Instructors)
                .WithOne(I=>I.InstructorDepartment)
                .HasForeignKey(I=>I.Dept_ID)
                .OnDelete(DeleteBehavior.Restrict);
            D   
                .HasMany(D=>D.Students)
                .WithOne(S=>S.Department)
                .HasForeignKey(S=>S.Dep_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
