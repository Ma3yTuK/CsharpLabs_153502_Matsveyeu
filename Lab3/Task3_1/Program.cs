using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int num, e = 1;
            Console.Write("Программа меняет местами цифры в двухзначных числах\n\n");
            do
            {
                switch (e)
                {
                    case 1:
                        Console.Write("Введите число: ");
                        while (!int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.Write("\nНеправильный ввод!\n");
                            Console.Write("Введите число: ");
                        }
                        Console.Write("Результат: {0}", Numbers.MyFunc(num));
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
