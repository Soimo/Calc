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
                    Console.WriteLine("0 - Выход");
                    string z = Console.ReadLine();
                    int c = int.Parse(z);

                    if (c == 0)
                    {
                        System.Environment.Exit(0);
                    }



                    Console.WriteLine("Введите первый операнд");
                    string x = Console.ReadLine();
                    double a;
                    if (double.TryParse(x, out a))
                    {
                        Console.WriteLine("\n Первый операнд: {0} \n", a);
                    }

                    else
                    {
                        Console.WriteLine("Неверный ввод. Повторите попытку \n");
                        x = Console.ReadLine();
                        if (double.TryParse(x, out a))
                        {
                            Console.WriteLine("\n Первый операнд: {0} \n", a);
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод. Первому операнду будет присвоено значение 0 \n");
                        }
                    }


                    Console.WriteLine("Введите второй операнд");
                    string y = Console.ReadLine();
                    double b;
                    if (double.TryParse(y, out b))
                    {
                        Console.WriteLine("\n Второй операнд: {0} \n", b);
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод. Повторите попытку \n");
                        x = Console.ReadLine();
                        if (double.TryParse(y, out b))
                        {
                            Console.WriteLine("\n Второй операнд: {0} \n", b);
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод. Второму операнду будет присвоено значение 0 \n");
                        }
                    }



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

                    Console.WriteLine("Продолжить? \n 1 - Да \n 2 - Нет \n \n");
                    n = Console.ReadLine();

                    if (int.TryParse(n, out m))
                    {
                        switch (m)
                        {
                            case 1:
                                break;

                            case 2:
                                System.Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Введена некорректная команда. Будет осуществлен выход");
                                Console.ReadLine();
                                break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Введена некорректная команда. Будет осуществлен выход");
                        Console.ReadLine();
                        System.Environment.Exit(0);
                    }

                } while (m == 1);

            

        }
    }
}
