﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomocnikKsiegowy
{
    internal class PiedziesiatProcent
    {
        public double NaPol(string liczba, double mnoznik)
        {
            double liczbaNaPol = Convert.ToDouble(liczba);
            double wynik = Math.Round(liczbaNaPol * mnoznik, 2);
            return wynik;
        }
    }
}
