using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Klasa zawiera metody do konwersji wartości netto i brutto oraz obliczania kwoty VAT.
    /// </summary>
    internal class BruttoNetto
    {
        /// <summary>
        /// Oblicza wartość netto na podstawie brutto i stawki VAT.
        /// </summary>
        /// <param name="brutto">Kwota brutto.</param>
        /// <param name="stawkaVat">Stawka VAT w ułamkach dziesiętnych (np. 0.23 dla 23%).</param>
        /// <returns>Obliczona kwota netto.</returns>
        public double BruttoNaNetto(double brutto, double stawkaVat)
        {
            double netto = brutto / (1 + stawkaVat);

            netto = Math.Round(netto, 2);

            return netto;
        }

        /// <summary>
        /// Oblicza wartość brutto na podstawie netto i stawki VAT.
        /// </summary>
        /// <param name="netto">Kwota netto.</param>
        /// <param name="stawkaVat">Stawka VAT w ułamkach dziesiętnych (np. 0.23 dla 23%).</param>
        /// <returns>Obliczona kwota brutto.</returns>
        public double NettoNaBrutto(double netto, double stawkaVat)
        {
            double brutto = netto * (1 + stawkaVat);

            brutto = Math.Round(brutto, 2);

            return brutto;
        }

        /// <summary>
        /// Oblicza kwotę VAT na podstawie różnicy między kwotą brutto a netto.
        /// </summary>
        /// <param name="liczba1">Kwota brutto.</param>
        /// <param name="liczba2">Kwota netto.</param>
        /// <returns>Obliczona kwota VAT.</returns>
        public double ustalVat(double liczba1, double liczba2)
        {
            double vat = liczba1 - liczba2;

            vat = Math.Round(vat, 2);

            return vat;
        }
    }
}
 