using System;
using System.Collections.Generic;
using System.Text;
using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data.Mapping
{
    class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            //Inheritance : THP, and renaming the discriminator
            builder.HasDiscriminator<string>("type")
                .HasValue<OnlineCourse>("Online")
                .HasValue<OnsiteCourse>("Onsite");

        }
    }
}
