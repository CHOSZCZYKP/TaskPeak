using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Uzytkownik : IdentityUser
    {
        public string Imie { get; set; } = default!;
        public string Nazwisko { get; set; } = default!;

        public Klient? Klient { get; set; }
        public Pracownik? Pracownik { get; set; }

    }
}
