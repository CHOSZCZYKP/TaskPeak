using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Pracownik
    {
        public string Id { get; set; }
        public DateTime DataZatrudnienia { get; set; }
        public Waluta StawkaZaGodz { get; set; }

        public Uzytkownik Uzytkownik { get; set; }

        public ICollection<Urlop>? Urlopy { get; set; }
        public ICollection<DziennyRaport>? DzienneRaporty { get; set; }

    }
}
