using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIESAPI;

namespace PomocnikKsiegowy
{
    internal class ManagerVies
    {
        VIESAPIClient viesapi = new VIESAPIClient("vKtQq3EpM3xC", "HkMVBXwF8jvs");

        public KontrahentVIES CheckTrader(string countryCode, string vatNumber)
        {
            VIESData vies = viesapi.GetVIESData(countryCode + vatNumber);

            KontrahentVIES trader = new KontrahentVIES()
            {


            };





        }
    }
}
