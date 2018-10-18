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
                //double a = double.Parse(x);
                double a;
                if (double.TryParse(x, out a))
                {
                    Console.WriteLine("\n Первый операнд: {0} \n", a);
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Операнд будет приведен к нулю \n");
                    
                }
                
                Console.WriteLine("Введите второй операнд");
                string y = Console.ReadLine();
                //double b = double.Parse(y);
                double b;
                if (double.TryParse(y, out b))
                {
                    Console.WriteLine("\n Второй операнд: {0} \n", b);
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Операнд будет приведен к нулю \n");
                    
                }



                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Сложение");
                Console.WriteLine("2 - Вычитание");
                Console.WriteLine("3 - Умножение");
                Console.WriteLine("4 - Деление \n");
                Console.WriteLine("0 - Выход");
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
