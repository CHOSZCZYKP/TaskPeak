using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class PozycjaFaktury
    {
        public int Id { get; set; }
        public Waluta CenaBrutto { get; set; } = default!;
        public Waluta CenaNetto { get; set; } = default!;
        public int Ilosc { get; set; }

        public int IdFaktury { get; set; }
        public Faktura Faktura { get; set; } = default!;

        public int IdUslugi { get; set; }
        public Usluga Usluga { get; set; } = default!;
    }
}
