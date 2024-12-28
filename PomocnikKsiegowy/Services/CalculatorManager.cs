using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Klasa zarządzająca operacjami kalkulatora. 
    /// Odpowiada za wykonywanie podstawowych operacji arytmetycznych na liczbach przechowywanych w obiekcie <see cref="Calculator"/>.
    /// </summary>
    internal class CalculatorManager
    {
        /// <summary>
        /// Wykonuje obliczenia na podstawie danych zawartych w obiekcie <see cref="Calculator"/>.
        /// </summary>
        /// <param name="calculator">Obiekt kalkulatora zawierający liczby i operator.</param>
        /// <returns>
        /// Wynik operacji matematycznej na podstawie operatora i liczb przekazanych w obiekcie kalkulatora.
        /// </returns>
        /// <remarks>
        /// Obsługiwane operatory to:
        /// <list type="bullet">
        /// <item>'*' - mnożenie</item>
        /// <item>'/' - dzielenie (z obsługą dzielenia przez zero)</item>
        /// <item>'+' - dodawanie</item>
        /// <item>'-' - odejmowanie</item>
        /// </list>
        /// </remarks>
        public double Oblicz(Calculator calculator)
        {
            double result = 0;

            switch(calculator.Operators)
            {
                case '*':
                    result = calculator.StorageNumber * calculator.SecondNumber;
                    break;

                case '/':
                    if (calculator.SecondNumber == 0)
                        result = 0;
                    else
                        result = calculator.StorageNumber / calculator.SecondNumber;
                    break;

                case '+':
                    result = calculator.StorageNumber + calculator.SecondNumber;
                    break;

                case '-':
                    result = calculator.StorageNumber - calculator.SecondNumber;
                    break;
            }

            // Reset operatora i liczb w kalkulatorze po wykonaniu obliczeń
            calculator.Operators = null;

            calculator.StorageNumber = 0.0;

            calculator.StorageNumber = 0.0;

            return result;
        }
    }
}
