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
    public class ZadanConfiguration : IEntityTypeConfiguration<Zadanie>
    {
        public void Configure(EntityTypeBuilder<Zadanie> builder)
        {
            builder.HasKey(z => z.Id);

            builder.Property(z => z.Id)
                .IsRequired();

            builder.Property(z => z.OpisZadania)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(z => z.DataPrzydzielenia)
                .IsRequired();

            builder.Property(z => z.Status)
                .IsRequired()
                .HasMaxLength(25);

            builder.HasOne(z => z.Pracownik)
                .WithMany(p => p.Zadania)
                .HasForeignKey(z => z.IdPracownika);

            builder.Property(z => z.IdPracownika)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(z => z.Rezerwacja)
                .WithMany(r => r.Zadania)
                .HasForeignKey(z => z.IdRezerwacji);

            builder.Property(z => z.IdRezerwacji)
                .IsRequired();
        }
    }
}
