using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Klasa reprezentuje dane dotyczące grzbietu segregatora, takie jak rok, miesiące, nazwa handlowa i inne właściwości.
    /// </summary>
    public class Spine
    {
        public string Year { get; set; }

        public string Month { get; set; }
        /// <summary>
        /// Określa, czy zakres miesięcy jest włączony.
        /// Wartość <c>true</c> oznacza, że grzbiet obejmuje zakres miesięcy, a nie pojedynczy miesiąc.
        /// </summary>
        public bool Range { get; set; }
        /// <summary>
        /// Pobiera lub ustawia drugi miesiąc w zakresie, jeśli <see cref="Range"/> jest ustawione na <c>true</c>.
        /// </summary>
        public string Month2 { get; set; }

        public string TraderName { get; set; }

        public bool Size { get; set; }
        /// <summary>
        /// Określa, czy grzbiet jest podzielony na sekcje.
        /// Wartość <c>true</c> oznacza, że grzbiet jest podzielony; <c>false</c> oznacza brak podziału.
        /// </summary>
        public bool Section { get; set; }
        /// <summary>
        /// Pobiera lub ustawia numer sekcji, jeśli <see cref="Section"/> jest ustawione na <c>true</c>.
        /// </summary>
        public string Parts { get; set; }
    }
}
