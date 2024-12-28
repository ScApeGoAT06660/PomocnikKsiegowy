using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomocnikKsiegowy
{
    internal class Half
    {
        public double ToHalf(double number, double multiplier)
        {
            double result = Math.Round(number * multiplier, 2);

            return result;
        }
    }
}
