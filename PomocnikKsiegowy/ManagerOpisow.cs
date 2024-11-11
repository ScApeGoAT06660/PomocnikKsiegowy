using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PomocnikKsiegowy
{
    internal class ManagerOpisow
    {
        string sciezka = @"C:\Users\Dom\source\repos\PomocnikKsiegowy\PomocnikKsiegowy\dane.txt";

        public List<string> WczytajOpisy()
        {
            string[] dane = File.ReadAllLines(sciezka);

            return new List<string>(dane);
        }

        public void Dodaj(string nowyOpis)
        {
            File.AppendAllText(sciezka, Environment.NewLine + nowyOpis);
        }

        private void Zapisz(List<string> opisy)
        {
            // Zapisujemy wszystkie opisy do pliku, każdemu przypisując nową linię
            File.WriteAllLines(sciezka, opisy);
        }


    }
}
