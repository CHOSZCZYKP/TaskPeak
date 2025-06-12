using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Pracownik
    {
        public string Id { get; set; } = default!;
        public DateTime DataZatrudnienia { get; set; }
        public Waluta StawkaZaGodz { get; set; } = default!;

        public Uzytkownik Uzytkownik { get; set; } = default!;

        public ICollection<Urlop> Urlopy { get; set; } = new List<Urlop>();
        public ICollection<DziennyRaport> DzienneRaporty { get; set; } = new List<DziennyRaport>();
        public ICollection<Zadanie> Zadania { get; set; } = new List<Zadanie>();

    }
}
