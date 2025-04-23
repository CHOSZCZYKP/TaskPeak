using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPeak.Domain.Entities;

namespace TaskPeak.Infrastructure.Data
{
    public class TaskPeakDbContext : IdentityDbContext
    {
        public TaskPeakDbContext(DbContextOptions<TaskPeakDbContext> options) : base(options)
        {
            
        }

        public DbSet<DziennyRaport> DzienneRaporty { get; set; }
        public DbSet<Faktura> Faktury { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Opinia> Opinie { get; set; }
        public DbSet<PozycjaFaktury> PozycjeFaktura { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Rezerwacja> Rezerwacje { get; set; }
        public DbSet<Urlop> Urlopy { get; set; }
        public DbSet<Usluga> Uslugi { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<Zadanie> Zadania { get; set; }
        public DbSet<Zgloszenie> Zgloszenia { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
