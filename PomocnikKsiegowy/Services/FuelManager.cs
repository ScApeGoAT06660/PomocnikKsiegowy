using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    internal class FuelManager
    {
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
