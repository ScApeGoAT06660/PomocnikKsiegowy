using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    internal class BruttoNetto
    {
        public double BruttoNaNetto(double brutto, double stawkaVat)
        {
            double netto = brutto / (1 + stawkaVat);

            netto = Math.Round(netto, 2);

            return netto;
        }

        public double NettoNaBrutto(double netto, double stawkaVat)
        {
            double brutto = netto * (1 + stawkaVat);

            brutto = Math.Round(brutto, 2);

            return brutto;
        }

        public double ustalVat(double liczba1, double liczba2)
        {
            double vat = liczba1 - liczba2;

            vat = Math.Round(vat, 2);

            return vat;
        }
    }
}
 