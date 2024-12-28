using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Klasa przechowuje listę podpowiedzi dla poszczególnych zakładek w aplikacji.
    /// </summary>
    internal class ToolTipsForTabs
    {
        private string[] tooltipsForTabs = {
            "Paliwo - oblicz paliwo i leasing",
            "Paliwo bez VAT i 50%",
            "Kalkulator - bez spacji jako separatora dziesiętnego ",
            "Schowek - do kopiowania opisów operacji",
            "Cropper - wytnij fragment wyciągu",
            "BruttoNetto - wyliczaj brutto i netto",
            "Nazwa Skrócona - zamień na duże",
            "Grzbiety - do segregatorów",
            "NBP - sprawdź kurs dla wybranej daty",
            "VIES - sprawdź kontrahenta"
        };

        /// <summary>
        /// Zwraca tablicę podpowiedzi dla zakładek.
        /// </summary>
        /// <returns>
        /// Tablica zawierająca podpowiedzi dla zakładek w formie tekstowej.
        /// Każdy element tablicy odpowiada jednej zakładce w aplikacji.
        /// </returns>
        public string[] GetToolTips()
        {
            return tooltipsForTabs;
        }
    }
}
