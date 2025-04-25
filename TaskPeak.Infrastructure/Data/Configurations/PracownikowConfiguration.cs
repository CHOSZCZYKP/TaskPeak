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
    public class PracownikowConfiguration : IEntityTypeConfiguration<Pracownik>
    {
        public void Configure(EntityTypeBuilder<Pracownik> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(p => p.DataZatrudnienia)
                .IsRequired();

            builder.OwnsOne(p => p.StawkaZaGodz, cmb =>
            {
                cmb.Property(w => w.Wartosc)
                    .HasPrecision(10, 2)
                    .IsRequired();
                cmb.Property(w => w.Nazwa)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            builder.HasOne(p => p.Uzytkownik)
                .WithOne(u => u.Pracownik)
                .HasForeignKey<Uzytkownik>(u => u.Id);
        }
    }
}
