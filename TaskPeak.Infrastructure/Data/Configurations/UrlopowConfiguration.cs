using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPeak.Domain.Entities;

namespace TaskPeak.Infrastructure.Data.Configurations
{
    public class UrlopowConfiguration : IEntityTypeConfiguration<Urlop>
    {
        public void Configure(EntityTypeBuilder<Urlop> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .IsRequired();

            builder.Property(u => u.DataPoczatkowa)
                .IsRequired();

            builder.Property(u => u.DataKoncowa)
                .IsRequired();

            builder.Property(u => u.IdPracownika)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(u => u.Pracownik)
                .WithMany(p => p.Urlopy)
                .HasForeignKey(u => u.IdPracownika);
        }
    }
}
