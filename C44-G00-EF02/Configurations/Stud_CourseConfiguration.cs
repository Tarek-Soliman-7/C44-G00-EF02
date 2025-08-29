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
    internal class Stud_CourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> SC)
        {
            SC.HasKey(T => new { T.Stud_Id, T.Course_Id });

            SC
                .HasOne(sc => sc.Student)
                .WithMany(s => s.stud_courses)
                .HasForeignKey(sc => sc.Stud_Id)
                .OnDelete(DeleteBehavior.Restrict);

            SC
                .HasOne(sc => sc.Course)
                .WithMany(c => c.stud_courses)
                .HasForeignKey(sc => sc.Course_Id)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
