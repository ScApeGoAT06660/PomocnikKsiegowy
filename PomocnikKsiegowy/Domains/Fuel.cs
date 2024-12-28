using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    internal class Fuel
    {
        public double Vat { get; set; }
        public double Netto { get; set; }
        public double Result { get; set; }
        public double Multiplier { get; set; }
        public bool Leasing { get; set; }
    }
}
