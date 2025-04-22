using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Zadanie
    {
        public int Id { get; set; }
        public string OpisZadania { get; set; }
        public DateTime DataPrzydzielenia { get; set; }
        public string Status { get; set; } //status wewnętrznego wykonania usługi

        public string IdPracownika { get; set; }
        public Pracownik Pracownik { get; set; }

        public int IdRezerwacji { get; set; }
        public Rezerwacja Rezerwacja { get; set; }
    }
}
