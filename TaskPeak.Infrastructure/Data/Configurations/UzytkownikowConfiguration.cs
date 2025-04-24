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
    public class UzytkownikowConfiguration : IEntityTypeConfiguration<Uzytkownik>
    {
        public void Configure(EntityTypeBuilder<Uzytkownik> builder)
        {
            builder.Property(u => u.Imie)
                .IsRequired()
                .HasMaxLength(50);
            
            builder.Property(u => u.Nazwisko)
                .IsRequired()
                .HasMaxLength(70);
        }
    }
}
