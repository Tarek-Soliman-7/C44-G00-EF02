﻿using C44_G00_EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G00_EF02.Configurations
{
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> CI)
        {
            CI.HasKey(X => new {X.Course_Id,X.Inst_Id});

            CI
                .HasOne(ci => ci.Course)
                .WithMany(c => c.Course_Insts)
                .HasForeignKey(ci => ci.Course_Id)
                .OnDelete(DeleteBehavior.Restrict);

            CI
                .HasOne(ci => ci.Instructor)
                .WithMany(I => I.Course_Insts)
                .HasForeignKey(ci => ci.Inst_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
