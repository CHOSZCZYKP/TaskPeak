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
    public class ZleceniaConfiguration : IEntityTypeConfiguration<Zlecenie>
    {
        public void Configure(EntityTypeBuilder<Zlecenie> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                .IsRequired();

            builder.Property(r => r.DataZlecenia)
                .IsRequired();

            builder.Property(r => r.Status)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(r => r.IdUslugi)
                .IsRequired();

            builder.Property(r => r.IdKlienta)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(r => r.Klient)
                .WithMany(k => k.Rezerwacje)
                .HasForeignKey(r => r.IdKlienta);

            builder.HasOne(r => r.Usluga)
                .WithMany(u => u.Rezerwacje)
                .HasForeignKey(r => r.IdUslugi);
        }
    }
}
