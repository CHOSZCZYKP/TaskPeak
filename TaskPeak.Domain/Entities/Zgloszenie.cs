using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Zgloszenie
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }

        public string IdKlienta { get; set; }
        public Klient Klient { get; set; }
    }
}
