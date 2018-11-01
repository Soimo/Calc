using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор \n \n");
            string n = "1";
            int m;
            double d;
            do
            {

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Сложение \n2 - Вычитание \n3 - Умножение \n4 - Деление \n");
                string z = Console.ReadLine();
                int c;
                if (int.TryParse(z, out c))
                {

                }
                else
                {
                    Console.WriteLine("Неверный ввод. Будет осуществлен выход");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }

                Console.WriteLine("Введите первый операнд");
                double a;
                GetOperand GetOp1 = new GetOperand();
                a = GetOp1.Operand(Console.ReadLine());

                Console.WriteLine("Введите второй операнд");
                double b;
                GetOperand GetOp2 = new GetOperand();
                b = GetOp2.Operand(Console.ReadLine());

                Calculation Calculate = new Calculation();
                d = Calculate.Compute(c, a, b);


                Console.WriteLine("Продолжить? \n 1 - Да \n 2 - Нет");
                Restart restart = new Restart();
                m = restart.RestartMethod(Console.ReadLine());
                
             

            } while (m == 1);

        }
    }
}
