using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class DziennyRaport
    {
        public int Id { get; set; }
        public string Opis { get; set; } = default!;
        public float IloscGodzin { get; set; }
        public DateTime Data { get; set; }

        public string IdPracownika { get; set; } = default!;
        public Pracownik Pracownik { get; set; } = default!;
    }
}
