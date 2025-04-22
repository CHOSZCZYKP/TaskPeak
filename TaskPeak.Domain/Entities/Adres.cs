using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPeak.Domain.Entities
{
    public class Adres
    {
        public string Miasto { get; set; } = default!;
        public string Ulica { get; set; } = default!;
        public string NrDomu_Lokalu { get; set; } = default!;
        public string KodPocztowy { get; set; } = default!;
    }
}
