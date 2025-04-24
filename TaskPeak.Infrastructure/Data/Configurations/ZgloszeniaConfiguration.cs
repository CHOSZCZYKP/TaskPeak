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
    public class ZgloszeniaConfiguration : IEntityTypeConfiguration<Zgloszenie>
    {
        public void Configure(EntityTypeBuilder<Zgloszenie> builder)
        {
            builder.HasKey(z => z.Id);

            builder.Property(z => z.Id)
                .IsRequired();

            builder.Property(z => z.Tytul)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(z => z.Opis)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(z => z.IdKlienta)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(z => z.Klient)
                .WithMany(k => k.Zgloszenia)
                .HasForeignKey(z => z.IdKlienta);
        }
    }
}
