using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    internal class CalculatorManager
    {
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

            calculator.Operators = null;

            calculator.StorageNumber = 0.0;

            calculator.StorageNumber = 0.0;

            return result;
        }
    }
}
