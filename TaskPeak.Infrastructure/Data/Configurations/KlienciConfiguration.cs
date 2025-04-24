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
    public class KlienciConfiguration : IEntityTypeConfiguration<Klient>
    {
        public void Configure(EntityTypeBuilder<Klient> builder)
        {
            builder.HasKey(k => k.Id);
            
            builder.Property(k => k.Id)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(k => k.Uzytkownik)
                .WithOne(u => u.Klient)
                .HasForeignKey<Uzytkownik>(u => u.Id);

            builder.Property(k => k.Firma)
                .HasMaxLength(200);

            builder.Property(k => k.NIP)
                .HasMaxLength(10);

            builder.Property(k => k.DataRejestracji)
                .IsRequired();

            builder.OwnsOne(k => k.Adres, cmb =>
            {
                cmb.Property(a => a.Miasto)
                    .IsRequired()
                    .HasMaxLength(100);
                cmb.Property(a => a.Ulica)
                    .IsRequired()
                    .HasMaxLength(100);
                cmb.Property(a => a.KodPocztowy)
                    .IsRequired()
                    .HasMaxLength(6);
                cmb.Property(a => a.NrDomu_Lokalu)
                    .IsRequired()
                    .HasMaxLength(10);
            });
        }
    }
}
