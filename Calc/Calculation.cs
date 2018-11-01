using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculation
    {

        public double Compute(int c, double a, double b)
        {
            double d = 0;

            switch (c)
            {
                case 1:
                    d = a + b;
                    Console.WriteLine("Результат операции: {0}", d);
                    break;
                case 2:
                    d = a - b;
                    Console.WriteLine("Результат операции: {0}", d);
                    break;
                case 3:
                    d = a * b;
                    Console.WriteLine("Результат операции: {0}", d);
                    break;
                case 4:
                    d = a / b;
                    Console.WriteLine("Результат операции: {0}", d);
                    break;
                default:
                    Console.WriteLine("Введена некорректная команда");
                    break;
            }

            return d;
        }
    }
}
