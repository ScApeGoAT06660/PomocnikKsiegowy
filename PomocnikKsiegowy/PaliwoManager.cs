using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    internal class PaliwoManager
    {
        public string ObliczPaliwo(Paliwo paliwo)
        {
            double wynik = 0;

            if (paliwo.leasing)
            {
                wynik = (paliwo.vat / 2) + paliwo.netto;
                wynik = Math.Round(wynik, 2);

            }
            else if (!paliwo.leasing)
            {
                wynik = ((paliwo.vat / 2) + paliwo.netto) * paliwo.mnoznik;
                wynik = Math.Round(wynik, 2);
            }

            return wynik.ToString();
        }
    }
}
