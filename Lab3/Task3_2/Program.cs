using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int e = 1;
            double z, b;
            Console.Write("Программа вычисляет значение выражения\n\n");
            do
            {
                switch (e)
                {
                    case 1:
                        Console.Write("Введите число z: ");
                        while (!double.TryParse(Console.ReadLine(), out z))
                        {
                            Console.Write("\nНеправильный ввод!\n");
                            Console.Write("Введите число z: ");
                        }
                        Console.Write("Введите число b: ");
                        while (!double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.Write("\nНеправильный ввод!\n");
                            Console.Write("Введите число b: ");
                        }
                        Calc.MyFunc(z, b);
                        break;
                    default:
                        Console.Write("\nНеправильный ввод!\n");
                        break;
                }
                Console.Write("\n\n1) Продолжить\n2) Закончить\nВыберите действие:");
                while (!int.TryParse(Console.ReadLine(), out e))
                {
                    Console.Write("\nНеправильный ввод!\n");
                    Console.Write("\n\n1) Продолжить\n2) Закончить\nВыберите действие:");
                }
            } while (e != 2);
        }
    }
}