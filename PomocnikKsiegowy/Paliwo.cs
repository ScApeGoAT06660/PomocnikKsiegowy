using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    internal class Paliwo
    {
        public double vat { get; set; }
        public double netto { get; set; }
        public double wynik { get; set; }
        public double mnoznik { get; set; }
        public bool leasing { get; set; }
    }
}
