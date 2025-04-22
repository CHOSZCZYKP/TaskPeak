using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Opinia
    {
        public int Id { get; set; }
        public float IloscGwiazdek { get; set; }
        public string Tresc { get; set; }

        public string IdKlienta { get; set; }
        public Klient Klient { get; set; }
    }
}
