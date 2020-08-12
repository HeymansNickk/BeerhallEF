using System;
using System.Collections.Generic;
using System.Text;
using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data.Mapping
{
    class BrewerConfiguration : IEntityTypeConfiguration<Brewer>
    {
        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            builder.ToTable("Brewer"); //Mappen van primary key

            #region Properties

            builder.Property(t => t.Name)
                .HasColumnName("BrewerName")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.ContactEmail).HasMaxLength(100);

            builder.Property(t => t.Street).HasMaxLength(100);

            builder.Property(t => t.BrewerId).ValueGeneratedOnAdd();
            #endregion

            #region Associations
            builder.HasMany(t => t.Beers)
                .WithOne()
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Location)
                .WithMany()
                .HasForeignKey(nameof(Location.PostalCode))
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion


        }
    }
}
