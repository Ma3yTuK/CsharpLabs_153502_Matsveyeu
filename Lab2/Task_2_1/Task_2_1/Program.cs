// See https://aka.ms/new-console-template for more information
using System;

namespace mynamespace // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static int MyFunc(int a)
        {
            int c = a % 10 + (a / 10) % 10;
            if (c % 2 != 0)
                return 1;
            else
                return 0;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a, b, e = 1;
            do {
                switch (e) {
                    case 1:
                        Console.Write("Введите двухзначное число: ");
                        while (!int.TryParse(Console.ReadLine(), out a) || a<10 || a>99)
                        {
                            Console.WriteLine("\nНеправильный ввод!\n");
                            Console.Write("Введите M: ");
                        }
                        b = MyFunc(a);
                        if (b != 0)
                            Console.Write("Сумма цифр числа нечетная\n");
                        else
                            Console.Write("Сумма цифр числа четная\n");
                        break;
                    case 2:
                        break;
                    default:
                        Console.Write("\nНеправильный ввод!\n");
                        break;
                }
                Console.Write("\n\n1) Продолжить\n2) Закончить\nВыберите действие:");
                while (!int.TryParse(Console.ReadLine(), out e))
                {
                    Console.WriteLine("\nНеправильный ввод!");
                    Console.Write("\n\n1) Продолжить\n2) Закончить\nВыберите действие:");
                }
            } while (e != 2);
        }
    }
}