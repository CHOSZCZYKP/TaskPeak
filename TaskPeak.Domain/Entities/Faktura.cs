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
        public string NrFaktury { get; set; }
        public DateTime DataWystawienia { get; set; }
        public DateTime TerminPlatnosci { get; set; }
        public DateTime DataWykonaniaUslugi { get; set; }
        public string Status { get; set; }
        public string MetodaPlatnosci { get; set; }
        public string Uwagi { get; set; }
        public Waluta KwotaBrutto { get; set; }
        public Waluta KwotaNetto { get; set; }

        public string IdKlienta { get; set; }
        public Klient Klient { get; set; }
    }
}
