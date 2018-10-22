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
            //Задаем по умолчанию переменную, которая будет задаваться пользователем и парсится в переменную, управляющую выходом из программы или ее повторным запуском
            string n = "1";
            //Объявляем переменную, которая будет управлять выходом из программы или ее повторным запуском
            int m;
            //Объявляем переменную - результат вычислений
            double d;
            //Начинаем основной цикл программы - ввод данных и получение результатов
            do
            {
                //Приглашение ввести первый операнд
                Console.WriteLine("Введите первый операнд");
                //Объявили переменную и получили ее из пользовательского ввода
                string x = Console.ReadLine();
                //Сюда мы буде парсить строку, полученную от пользователя
                double a;
                //Пытаемся распарсить то. что ввел пользователь
                if (double.TryParse(x, out a)) 
                {
                    //Если то, что ввел пользователь распарсится как double, то выводим сообщение, что все ОК и переходим к вводу второго опернда
                    Console.WriteLine("\n Первый операнд: {0} \n", a);
                }

                //Если данные, введенные пользователем не распарсились
                else
                {
                    //Предлагаем пользователю ввести данные еще раз
                    Console.WriteLine("Неверный ввод. Повторите попытку \n");
                    x = Console.ReadLine();
                    //Парсим повторный ввод
                    if (double.TryParse(x, out a))
                    {
                        //Удалось распарсить со второй попытки - переходим к вводу второго операнда
                        Console.WriteLine("\n Первый операнд: {0} \n", a);
                    }
                    else
                    {
                        //Если пользователь ввел некорректные данные дважды, то присваиваем значение 0
                        Console.WriteLine("Неверный ввод. Первому операнду будет присвоено значение 0 \n");
                    }
                }


                //Получаем второй операнд по аналогии с первым
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


                //Проверка. Если оба операнда равны нулю, значит нет смысла спрашивать о том какую операцию с ними нужно совершить
                if ((a == 0) & (b == 0)) 
                {
                    Console.WriteLine("Результат любой арифметической операции будет 0 \n");
                }
                
                //После того как мы получили оба операнда мы приступаем к выбору арифметической операции
                else
                {
                    //Предложение выбора операции
                    Console.WriteLine("Выберите операцию:"); 
                    Console.WriteLine("1 - Сложение \n2 - Вычитание \n3 - Умножение \n4 - Деление \n");
                    Console.WriteLine("0 - Выход");
                    string z = Console.ReadLine();
                    int c = int.Parse(z);
                    
                    //В зависимости от ввода производим операцию
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
                        case 0:
                            System.Environment.Exit(0);
                            break;
                            //Пользователь ввел значение не соответствующее предложенным выриантам
                        default:
                            Console.WriteLine("Введена некорректная команда"); 
                            break;
                    }
                }
                
                //Предлагаем пользователю либо вернуться к do, либо выйти из программы
                Console.WriteLine("Продолжить? \n 1 - Да \n 2 - Нет");
                n = Console.ReadLine();
                
                //Пытаемся распарсить пользовательский ввод
                if (int.TryParse(n, out m))
                {
                    switch (m)
                    {
                        case 1:
                            break;

                        case 2:
                            System.Environment.Exit(0);
                            break;
                        
                        //Если пользовательский ввод распарсился, но не соответствует ни одному из предложенных вариантов, то выходим из программы
                        default:
                            Console.WriteLine("Введена некорректная команда. Будет осуществлен выход");
                            Console.ReadLine();
                            break;
                    }
                }

                //Если не удалось распарсить переменную n, то выходим из программы
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
