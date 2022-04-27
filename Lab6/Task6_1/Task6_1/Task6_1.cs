using System;

namespace Task6_1
{
    public class Program
    {
        public static void Main()
        {
            int choice, tmp;
            do
            {
                Console.Write("\n1) Create chair\n" +
                    "2) Create table\n" +
                    "3) Exit\n" +
                    "Choose action: ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("\nWrong input!");
                    Console.Write("\n1) Create chair\n" +
                    "2) Create table\n" +
                    "3) Exit\n" +
                    "Choose action: ");
                }
                switch (choice)
                {
                    case 1:
                        {
                            Chair obj = new Chair();
                            while (obj.Model == string.Empty) {
                                Console.Write("Model name: ");
                                obj.Model = Console.ReadLine();
                            }
                            Console.Write("Weight: ");

                            while (!int.TryParse(Console.ReadLine(), out tmp))
                            {
                                Console.WriteLine("\nWrong input!");
                                Console.Write("Weight: ");
                            }
                            obj.Weight = tmp;

                            Console.Write("Height: ");
                            while (!int.TryParse(Console.ReadLine(), out tmp))
                            {
                                Console.WriteLine("\nWrong input!");
                                Console.Write("Height: ");
                            }
                            obj.Height = tmp;

                            Console.Write("Width: ");
                            while (!int.TryParse(Console.ReadLine(), out tmp))
                            {
                                Console.WriteLine("\nWrong input!");
                                Console.Write("Width: ");
                            }
                            obj.Width = tmp;

                            Console.Write("Length: ");
                            while (!int.TryParse(Console.ReadLine(), out tmp))
                            {
                                Console.WriteLine("\nWrong input!");
                                Console.Write("Length: ");
                            }
                            obj.Length = tmp;
                            do
                            {
                                Console.Write("\n1) Fold\n" +
                                    "2) Unfold\n" +
                                    "3) Area\n" +
                                    "4) Order\n" +
                                    "5) To main menu\n" +
                                    "Choose action: ");
                                while (!int.TryParse(Console.ReadLine(), out choice))
                                {
                                    Console.WriteLine("\nWrong input!");
                                    Console.Write("\n1) Fold\n" +
                                    "2) Unfold\n" +
                                    "3) Area\n" +
                                    "4) Order\n" +
                                    "5) To main menu\n" +
                                    "Choose action: ");
                                }
                                switch (choice)
                                {
                                    case 1:
                                        obj.fold();
                                        break;
                                    case 2:
                                        obj.unfold();
                                        break;
                                    case 3:
                                        Console.WriteLine("Area: {0}", obj.area());
                                        break;
                                    case 4:
                                        Console.WriteLine("How many? ");
                                        while (!int.TryParse(Console.ReadLine(), out tmp))
                                        {
                                            Console.WriteLine("\nWrong input!");
                                            Console.WriteLine("How many? ");
                                        }
                                        obj.order(tmp);
                                        break;
                                }
                            } while (choice != 5);
                            break;
                        }
                    case 2:
                        {
                            RoundTable obj = new RoundTable();
                            while (obj.Model == string.Empty)
                            {
                                Console.Write("Model name: ");
                                obj.Model = Console.ReadLine();
                            }
                            Console.Write("Weight: ");

                            while (!int.TryParse(Console.ReadLine(), out tmp))
                            {
                                Console.WriteLine("\nWrong input!");
                                Console.Write("Weight: ");
                            }
                            obj.Weight = tmp;

                            Console.Write("Height: ");
                            while (!int.TryParse(Console.ReadLine(), out tmp))
                            {
                                Console.WriteLine("\nWrong input!");
                                Console.Write("Height: ");
                            }
                            obj.Height = tmp;

                            Console.Write("Radius: ");
                            while (!int.TryParse(Console.ReadLine(), out tmp))
                            {
                                Console.WriteLine("\nWrong input!");
                                Console.Write("Radius: ");
                            }
                            obj.Radius = tmp;
                            do
                            {
                                Console.Write("\n1) Fold\n" +
                                    "2) Unfold\n" +
                                    "3) Area\n" +
                                    "4) Order\n" +
                                    "5) To main menu\n" +
                                    "Choose action: ");
                                while (!int.TryParse(Console.ReadLine(), out choice))
                                {
                                    Console.WriteLine("\nWrong input!");
                                    Console.Write("\n1) Fold\n" +
                                    "2) Unfold\n" +
                                    "3) Area\n" +
                                    "4) Order\n" +
                                    "5) To main menu\n" +
                                    "Choose action: ");
                                }
                                switch (choice)
                                {
                                    case 1:
                                        obj.fold();
                                        break;
                                    case 2:
                                        obj.unfold();
                                        break;
                                    case 3:
                                        Console.WriteLine("Area: {0}", obj.area());
                                        break;
                                    case 4:
                                        obj.order();
                                        break;
                                }
                            } while (choice != 5);
                            break;
                        }
                }
            } while (choice != 3);
        }
    }
}