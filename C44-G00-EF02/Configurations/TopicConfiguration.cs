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
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> T)
        {
            T.HasIndex(T => T.Name).IsUnique();

            T
                .HasMany(T => T.Courses)
                .WithOne(C => C.Topic)
                .HasForeignKey(C => C.Top_ID)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
