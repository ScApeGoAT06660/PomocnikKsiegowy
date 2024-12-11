using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PomocnikKsiegowy
{
    public class ManagerOpisow
    {
        public string sciezka;

        public List<string> WczytajOpisy()
        {
            string[] dane = File.ReadAllLines(sciezka);

            List<string> posortowaneDane = new List<string>(dane);
            posortowaneDane.Sort();

            return posortowaneDane;
        }

        public void Dodaj(string nowyOpis)
        {
            File.AppendAllText(sciezka, Environment.NewLine + nowyOpis);
        }
    }
}
