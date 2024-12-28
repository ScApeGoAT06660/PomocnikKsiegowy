using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Klasa reprezentuje kalkulator służący do przechowywania liczb i operatorów matematycznych.
    /// </summary>
    internal class Calculator
    {
        /// <summary>
        /// Pobiera lub ustawia pierwszą liczbę w operacji matematycznej.
        /// </summary>
        public double StorageNumber { get; set; }
        /// <summary>
        /// Pobiera lub ustawia drugą liczbę w operacji matematycznej.
        /// </summary>
        public double SecondNumber { get; set; }
        /// <summary>
        /// Pobiera lub ustawia operator matematyczny używany w operacji.
        /// Możliwe wartości to '+', '-', '*' lub '/'.
        /// </summary>
        public char? Operators { get; set; }
    }
}
