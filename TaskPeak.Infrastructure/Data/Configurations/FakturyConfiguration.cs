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
    public class FakturyConfiguration : IEntityTypeConfiguration<Faktura>
    {
        public void Configure(EntityTypeBuilder<Faktura> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f)
                .IsRequired();

            builder.Property(f => f.NrFaktury)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(f => f.DataWystawienia)
                .IsRequired();

            builder.Property(f => f.TerminPlatnosci)
                .IsRequired();

            builder.Property(f => f.DataWykonaniaUslugi)
                .IsRequired();

            builder.Property(f => f.Status)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(f => f.MetodaPlatnosci)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(f => f.Uwagi)
                .HasMaxLength(200);

            builder.OwnsOne(f => f.KwotaBrutto, cmb =>
            {
                cmb.Property(w => w.Wartosc)
                    .HasPrecision(10, 2)
                    .IsRequired();
                cmb.Property(w => w.Nazwa)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            builder.OwnsOne(f => f.KwotaNetto, cmb =>
            {
                cmb.Property(w => w.Wartosc)
                    .HasPrecision(10, 2)
                    .IsRequired();
                cmb.Property(w => w.Nazwa)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            builder.Property(f => f.IdKlienta)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(f => f.Klient)
                .WithMany(k => k.Faktury)
                .HasForeignKey(f => f.IdKlienta);
        }
    }
}
