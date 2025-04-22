using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Urlop
    {
        public int Id { get; set; }
        public DateTime DataPoczatkowa { get; set; }
        public DateTime DataKoncowa { get; set; }

        public Pracownik Pracownik { get; set; } = default!;
        public string IdPracownika { get; set; } = default!;

    }
}
