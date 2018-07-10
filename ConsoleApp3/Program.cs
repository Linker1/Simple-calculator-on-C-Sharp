using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            double a, b, total;

            do
            {

                Console.WriteLine("Введите первый операнд");

                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второй операнд");

                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию");
                Console.WriteLine("0 - Выйти");
                Console.WriteLine("1 - Сложение");
                Console.WriteLine("2 - Вычитание");
                Console.WriteLine("3 - Умножение");
                Console.WriteLine("4 - Деление");

                choice = int.Parse(Console.ReadLine());

                if (choice > 4)
                {
                    Console.WriteLine("Неверная команда");
                }

                switch (choice)
                {
                    case 0:
                        {
                            Environment.Exit(0);
                        }
                        break;

                    case 1:
                        {
                            total = a + b;
                            Console.WriteLine(total);
                        }
                        break;

                    case 2:
                        {
                            total = a - b;
                            Console.WriteLine(total);
                        }
                        break;

                    case 3:
                        {
                            total = a * b;
                            Console.WriteLine(total);
                        }
                        break;

                    case 4:
                        {
                            total = a / b;
                            Console.WriteLine(total);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Неверная команда");
                        }
                        break;
                }


            } while (choice != 0);

        }
    }
}
