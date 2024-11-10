using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    internal class ManagerKalkulator
    {
        public double Oblicz(Kalkulator kalkulator)
        {
            double wynik = 0;

            switch(kalkulator.operators)
            {
                case '*':
                    wynik = kalkulator.storageNumber * kalkulator.secondNumber;
                    break;

                case '/':
                    if (kalkulator.secondNumber == 0)
                        wynik = 0;
                    else
                        wynik = kalkulator.storageNumber / kalkulator.secondNumber;
                    break;

                case '+':
                    wynik = kalkulator.storageNumber + kalkulator.secondNumber;
                    break;

                case '-':
                    wynik = kalkulator.storageNumber - kalkulator.secondNumber;
                    break;
            }

            kalkulator.operators = null;
            kalkulator.storageNumber = 0.0;
            kalkulator.storageNumber = 0.0;

            return wynik;
        }
    }
}
