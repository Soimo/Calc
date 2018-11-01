using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class NumEnter
    {
        public double GetNum(out int oN)
        {
            string opName;
            string oN = "0";
            opName = oN;
            string op1s;
            double op1d;
            Console.WriteLine("Введите {0} операнд \n", opName);
            op1s = Console.ReadLine();
            if (double.TryParse(op1s, out op1d))
            {
                Console.WriteLine("\n Первый операнд: {0} \n", op1d);
            }

            else
            {
                Console.WriteLine("Неверный ввод. Повторите попытку \n");
                x = Console.ReadLine();
                if (double.TryParse(op1s, out op1d))
                {
                    Console.WriteLine("\n Первый операнд: {0} \n", op1d);
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Первому операнду будет присвоено значение 0 \n");
                }

            }
            return op1d;
        }
    }
}
