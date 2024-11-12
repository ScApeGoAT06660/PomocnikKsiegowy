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
        string sciezka = @"C:\Users\Julita\Source\Repos\PomocnikKsiegowy\PomocnikKsiegowy\dane.txt";

        public List<string> WczytajOpisy()
        {
            string[] dane = File.ReadAllLines(sciezka);

            return new List<string>(dane);
        }

        public void Dodaj(string nowyOpis)
        {
            File.AppendAllText(sciezka, Environment.NewLine + nowyOpis);
        }
    }
}
