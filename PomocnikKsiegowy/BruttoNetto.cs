using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    internal class BruttoNetto
    {
        public double BruttoNaNetto(string brutto, double stawkaVat)
        {
            double bruttoLiczba = Convert.ToDouble(brutto);
            double netto = bruttoLiczba / (1 + stawkaVat);
            netto = Math.Round(netto, 2);

            return netto;
        }

        public double NettoNaBrutto(string netto, double stawkaVat)
        {
            double nettoLiczba = Convert.ToDouble(netto);
            double brutto = nettoLiczba * (1 + stawkaVat);
            brutto = Math.Round(brutto, 2);

            return brutto;
        }

        public double ustalVat(string liczba1, string liczba2)
        {
            double liczbaCon1 = Convert.ToDouble(liczba1);
            double liczbaCon2 = Convert.ToDouble(liczba2);

            double vat = liczbaCon1 - liczbaCon2;
            vat = Math.Round(vat, 2);

            return vat;
        }
    }
}
 