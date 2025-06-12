using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Faktura
    {
        public int Id { get; set; }
        public string NrFaktury { get; set; } = default!;
        public DateTime DataWystawienia { get; set; } = DateTime.Now;
        public DateTime TerminPlatnosci { get; set; }
        public DateTime DataWykonaniaUslugi { get; set; }
        public string Status { get; set; } = default!;
        public string MetodaPlatnosci { get; set; } = default!;
        public string? Uwagi { get; set; }
        public Waluta KwotaBrutto { get; set; } = default!;
        public Waluta KwotaNetto { get; set; } = default!;

        public string IdKlienta { get; set; } = default!;
        public Klient Klient { get; set; } = default!;

        public ICollection<PozycjaFaktury>? PozycjeFaktury { get; set; }
    }
}
