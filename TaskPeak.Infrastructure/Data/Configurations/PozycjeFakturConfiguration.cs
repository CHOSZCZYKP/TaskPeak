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
    public class PozycjeFakturConfiguration : IEntityTypeConfiguration<PozycjaFaktury>
    {
        public void Configure(EntityTypeBuilder<PozycjaFaktury> builder)
        {
            builder.HasKey(pf =>  pf.Id);

            builder.Property(pf => pf.Id)
                .IsRequired();

            builder.OwnsOne(pf => pf.CenaBrutto, cmb =>
            {
                cmb.Property(w => w.Wartosc)
                    .HasPrecision(10, 2)
                    .IsRequired();
                cmb.Property(w => w.Nazwa)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            builder.OwnsOne(pf => pf.CenaNetto, cmb =>
            {
                cmb.Property(w => w.Wartosc)
                    .HasPrecision(10, 2)
                    .IsRequired();
                cmb.Property(w => w.Nazwa)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            builder.Property(pf => pf.Ilosc)
                .IsRequired();

            builder.HasOne(pf => pf.Faktura)
                .WithMany(f => f.PozycjeFaktury)
                .HasForeignKey(pf => pf.IdFaktury);

            builder.HasOne(pf => pf.Usluga)
                .WithMany(u => u.PozycjeFaktur)
                .HasForeignKey(pf => pf.IdUslugi);
        }
    }
}
