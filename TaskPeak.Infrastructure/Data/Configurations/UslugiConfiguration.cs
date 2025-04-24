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
    public class UslugiConfiguration : IEntityTypeConfiguration<Usluga>
    {
        public void Configure(EntityTypeBuilder<Usluga> builder)
        {
            builder.HasKey(u =>  u.Id);

            builder.Property(u => u.Id)
                .IsRequired();

            builder.Property(u => u.Nazwa)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Opis)
                .IsRequired()
                .HasMaxLength(500);

            builder.OwnsOne(u => u.CenaNetto, cmb =>
            {
                cmb.Property(w => w.Wartosc)
                    .HasPrecision(10, 2)
                    .IsRequired();
                cmb.Property(w => w.Nazwa)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            builder.Property(u => u.StawkaVat)
                .IsRequired()
                .HasPrecision(5, 4);
        }
    }
}
