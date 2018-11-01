using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class GetOperand
    {
        public double Operand(string x)
        {
            double a;
            if (double.TryParse(x, out a))
            {
                Console.WriteLine("Вы ввели {0}", a);
            }
            else
                Console.WriteLine("Невеный ввод. Операнд приведен к нулю");

            return a;
        }

    }
}
