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

        public ICollection<Opinia> Opinie { get; set; } = new List<Opinia>();
        public ICollection<Zgloszenie> Zgloszenia { get; set; } = new List<Zgloszenie>();
        public ICollection<Faktura> Faktury { get; set; } = new List<Faktura>();
        public ICollection<Zlecenie> Rezerwacje { get; set; } = new List<Zlecenie>();
    }
}
