// See https://aka.ms/new-console-template for more information
using System;

namespace mynamespace // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static int MyFunc(double a, double b)
        {
            if (a > 40 || a < -40 || b > 40 || b < -40)
                return -1;
            else if (a < 40 && a > -40 && b < 40 && b > -40)
                return 1;
            else
                return 0;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double a, b, c;
            int e = 1;
            do
            {
                switch (e)
                {
                    case 1:
                        Console.Write("Введите X координату: ");
                        while (!double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("\nНеправильный ввод!\n");
                            Console.Write("Введите X координату: ");
                        }
                        Console.Write("Введите Y координату: ");
                        while (!double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("\nНеправильный ввод!\n");
                            Console.Write("Введите Y координату: ");
                        }
                        c = MyFunc(a, b);
                        if (c==-1)
                            Console.Write("Нет\n");
                        else if (c==1)
                            Console.Write("Да\n");
                        else
                            Console.Write("На границе\n");
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