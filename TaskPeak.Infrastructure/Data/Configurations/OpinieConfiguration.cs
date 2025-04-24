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
    public class OpinieConfiguration : IEntityTypeConfiguration<Opinia>
    {
        public void Configure(EntityTypeBuilder<Opinia> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id)
                .IsRequired();

            builder.Property(o => o.Tresc)
                .HasMaxLength(500);

            builder.Property(o => o.IloscGwiazdek)
                .IsRequired();

            builder.Property(o => o.IdKlienta)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(o => o.Klient)
                .WithMany(k => k.Opinie)
                .HasForeignKey(o => o.IdKlienta);
        }
    }
}
