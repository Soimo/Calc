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
            int m ;
            do

            {
                
                Console.WriteLine("Введите первый операнд");
                string x = Console.ReadLine();
                double a = double.Parse(x);
                                
                Console.WriteLine("Введите второй операнд");
                string y = Console.ReadLine();
                double b = double.Parse(y);
                                
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Сложение \n 2 - Вычитание \n 3 - Умножение \n 4 - Деление \n \n 0 - Выход");
                string z = Console.ReadLine();
                int c = int.Parse(z);
                double d = 0;

                switch (c)

                {
                    case 1:
                        d = a + b;
                        break;

                    case 2:
                        d = a - b;
                        break;

                    case 3:
                        d = a * b;
                        break;

                    case 4:
                        d = a / b;
                        break;

                    case 0:
                        System.Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("Введена некорректная команда");

                        break;
                }

                Console.WriteLine("Результат операции: {0}", d);
                Console.WriteLine("Продолжить? \n 1 - Да \n 2 - Нет");
                n = Console.ReadLine();
                m = int.Parse(n);
                


            } while (m == 1);

            

        }
    }
}
