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
    public class DziennychRaportowConfiguration : IEntityTypeConfiguration<DziennyRaport>
    {
        public void Configure(EntityTypeBuilder<DziennyRaport> builder)
        {
            builder.HasKey(dr => dr.Id);

            builder.Property(dr => dr.Id)
                .IsRequired();

            builder.Property(dr => dr.Opis)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(dr => dr.IloscGodzin)
                .IsRequired();

            builder.Property(dr => dr.IdPracownika)
                .HasMaxLength(450)
                .IsRequired();

            builder.Property(dr => dr.Data)
                .IsRequired();
            
            builder.HasOne(dr => dr.Pracownik)
                .WithMany(p => p.DzienneRaporty)
                .HasForeignKey(dr => dr.IdPracownika);
        }
    }
}
