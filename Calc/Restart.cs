using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Restart
    {
        public int RestartMethod(string n)
        {
            int m;
            if (int.TryParse(n, out m))
            {
                switch (m)
                {
                    case 1:
                        break;

                    case 2:
                        Console.WriteLine("Вы выбрали Выход");
                        System.Threading.Thread.Sleep(5000);
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

            return m;
        }

    }
}
