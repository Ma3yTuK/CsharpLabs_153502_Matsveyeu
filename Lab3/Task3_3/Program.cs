using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int input;
            Console.Write("Задание 3\n\n");
            do
            {
                Console.Write("\n\n1) Определить день недели\n2) Определить сколько дней осталось до (прошло с) определенной даты\n3) Выход\nВыберите действие:");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("\nНеправильный ввод!\n");
                    Console.Write("\n\n1) Определить день недели\n2) Определить сколько дней осталось до (прошло с) определенной даты\n3) Выход\nВыберите действие:");
                }
                switch (input)
                {
                    case 1:
                        Console.Write("Введите дату: ");
                        input = DateService.GetDay(Console.ReadLine());
                        while (input==-1)
                        {
                            Console.Write("\nНеправильный ввод!\n");
                            Console.Write("Введите дату: ");
                            input = DateService.GetDay(Console.ReadLine());
                        }
                        switch (input)
                        {
                            case 1:
                                Console.Write("Понедельник\n");
                                break;
                            case 2:
                                Console.Write("Вторник\n");
                                break;
                            case 3:
                                Console.Write("Среда\n");
                                break;
                            case 4:
                                Console.Write("Четверг\n");
                                break;
                            case 5:
                                Console.Write("Пятница\n");
                                break;
                            case 6:
                                Console.Write("Суббота\n");
                                break;
                            case 7:
                                Console.Write("Воскресенье\n");
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("Введите дату: ");
                        input = DateService.GetSpan(Console.ReadLine());
                        while (input == -1)
                        {
                            Console.Write("\nНеправильный ввод!\n");
                            Console.Write("Введите дату: ");
                            input = DateService.GetSpan(Console.ReadLine());
                        }
                        Console.Write("Осталось (прошло) дней: {0}\n", input);
                        break;
                    case 3:
                        Console.Write("До свидания!\n");
                        break;
                    default:
                        Console.Write("\nНеправильный ввод!\n");
                        break;
                }
            } while (input != 3);
        }
    }
}