using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Rezerwacja
    {
        public int Id { get; set; }
        public DateTime DataRezerwacji { get; set; }
        public string Status { get; set; } = default!; //status klienta zamówienia

        public ICollection<Zadanie>? Zadania { get; set; }

        public int IdUslugi { get; set; }
        public Usluga Usluga { get; set; } = default!;

    }
}
