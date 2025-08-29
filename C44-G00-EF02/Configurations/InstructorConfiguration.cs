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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I
                .Property(I => I.Salary)
                .HasColumnType("decimal(10,2)");
            I
                .Property(I => I.HourRateBouns)
                .HasColumnType("decimal(10,2)");

            I
                .HasOne(I => I.MangedDepartment)
                .WithOne(D => D.Manager)
                .HasForeignKey<Department>(D => D.Ins_ID)
                .OnDelete(DeleteBehavior.Restrict);

            //I
            //    .HasOne(I=>I.InstructorDepartment)
            //    .WithMany(D=>D.Instructors)
            //    .HasForeignKey(I => I.Dept_ID)
            //    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
