using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Usluga
    {
        public int Id { get; set; }
        public string Nazwa { get; set; } = default!;
        public string Opis { get; set; } = default!;
        public Waluta CenaNetto { get; set; } = default!;
        public decimal StawkaVat { get; set; }

        public ICollection<PozycjaFaktury>? PozycjeFaktur { get; set; }
        public ICollection<Rezerwacja>? Rezerwacje { get; set; }
    }
}
