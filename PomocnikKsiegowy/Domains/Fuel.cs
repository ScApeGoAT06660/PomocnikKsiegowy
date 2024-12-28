using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Klasa reprezentuje dane dotyczące paliwa, w tym wartości netto, VAT oraz opcje leasingowe.
    /// </summary>
    internal class Fuel
    {
        public double Vat { get; set; }
        public double Netto { get; set; }
        public double Result { get; set; }
        /// <summary>
        /// Pobiera lub ustawia mnożnik używany w obliczeniach paliwa.
        /// Mnożnik określa udział procentowy, np. 0.20 dla 20% paliwa używanego prywatnie.
        /// </summary>
        public double Multiplier { get; set; }
        /// <summary>
        /// Określa, czy operacja jest leasingiem.
        /// Wartość <c>true</c> oznacza, że jest leasingiem; <c>false</c> w przeciwnym wypadku.
        /// </summary>
        public bool Leasing { get; set; }
    }
}
