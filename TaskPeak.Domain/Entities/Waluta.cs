using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Waluta
    {
        public decimal Wartosc { get; set; }
        public string Nazwa { get; set; } = default!;
    }
}
