using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Klient
    {
        public string Id { get; set; } = default!;
        public string? Firma { get; set; }
        public string? NIP { get; set; }
        public Adres Adres { get; set; } = default!;
        public DateTime DataRejestracji { get; set; }

        public Uzytkownik Uzytkownik { get; set; } = default!;

        public ICollection<Opinia>? Opinie { get; set; }
        public ICollection<Zgloszenie>? Zgloszenia { get; set; }
        public ICollection<Faktura>? Faktury { get; set; }
        public ICollection<Rezerwacja>? Rezerwacje { get; set; }
    }
}
