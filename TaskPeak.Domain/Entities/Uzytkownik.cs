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
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Klient Klient { get; set; }
        public Pracownik Pracownik { get; set; }

    }
}
