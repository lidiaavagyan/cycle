using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Введите целое число:");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
            Console.ReadKey();

            Console.Write("\nПривет! Сколько у вас карт?");
            int armCards = int.Parse(Console.ReadLine());
            int Sum = 0;

            for (int g = 1; g <= armCards; g++)
            {
                Console.Write("Назовите вашу карту:\n");
                string armValue = Console.ReadLine();

                switch (armValue)
                {
                    case "2":
                    case "J":
                        Sum += 2;
                        break;
                    case "3":
                    case "Q":
                        Sum += 3;
                        break;
                    case "4":
                    case "K":
                        Sum += 4;
                        break;
                    case "6":
                        Sum += 6;
                        break;
                    case "7":
                        Sum += 7;
                        break;
                    case "8":
                        Sum += 8;
                        break;
                    case "9":
                        Sum += 9;
                        break;
                    case "10":
                        Sum += 10;
                        break;
                    case "11":
                    case "T":
                        Sum += 11;
                        break;
                }
            }
            Console.WriteLine("Сумма карт на руках: " + Sum);
            Console.ReadKey();

            int j;
            int r;
            int k;
            Console.WriteLine("\nВведите целое число:");
            j = Convert.ToInt32(Console.ReadLine());

            k = 0;
            r = 2;
            while (r <= j / 2)
            {
                if (j % r == 0)
                {
                    k = 1;
                    break;
                }
                r++;
            }
            if (k == 0)
                Console.WriteLine("Простое число");
            else
                Console.WriteLine("Не простое число");
            Console.ReadKey();

            Console.Write("\nВведите длину последовательности : ");
            int f = Int32.Parse(Console.ReadLine()), min = int.MaxValue, val = -1;
            for (; f > 0; f--)
            {
                val = Int32.Parse(Console.ReadLine());
                min = min > val ? val : min;
            }
            Console.WriteLine("min : " + min);
            Console.ReadKey();

            Console.WriteLine("\nУгадай число!)");
            Random rand = new Random();
            Console.WriteLine("\nВведите максимальное число: ");
            int z = Convert.ToInt32(Console.ReadLine());
            int num = rand.Next(0, z);
            int userNum;

            do
            {
                Console.Write("\nВведите число: ");
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum < num)
                {
                    Console.WriteLine("Введенное число меньше загаданного");
                }
                else if (userNum > num)
                {
                    Console.WriteLine("Введенное число больше загаданного");
                }
                else
                {
                    Console.WriteLine($"Вы угадали!");
                    Console.ReadKey();
                    break;
                }
            }
            while (true);
        }
    }
}