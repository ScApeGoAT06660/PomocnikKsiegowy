using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Klasa zarządzająca obliczeniami związanymi z paliwem, w tym uwzględnianiem VAT, netto, leasingu i mnożnika.
    /// </summary>
    internal class FuelManager
    {
        /// <summary>
        /// Oblicza koszt paliwa na podstawie danych przekazanych w obiekcie <see cref="Fuel"/>.
        /// </summary>
        /// <param name="fuel">Obiekt zawierający informacje o netto, VAT, leasingu i mnożniku.</param>
        /// <returns>
        /// Wynik obliczenia kosztu paliwa jako ciąg znaków.
        /// </returns>
        /// <remarks>
        /// - Jeśli paliwo jest objęte leasingiem, wynik jest sumą netto i połowy VAT.
        /// - Jeśli paliwo nie jest objęte leasingiem, wynik uwzględnia także mnożnik.
        /// Wynik jest zaokrąglony do dwóch miejsc po przecinku.
        /// </remarks>
        public string CalculateFuel(Fuel fuel)
        {
            double result = 0;

            if (fuel.Leasing)
            {
                result = (fuel.Vat / 2) + fuel.Netto;

                result = Math.Round(result, 2);

            }
            else if (!fuel.Leasing)
            {
                result = ((fuel.Vat / 2) + fuel.Netto) * fuel.Multiplier;

                result = Math.Round(result, 2);
            }

            return result.ToString();
        }
    }
}
