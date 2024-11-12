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
    }
}
 