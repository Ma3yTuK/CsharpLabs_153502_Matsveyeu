using System;
using tarifNamespace;

namespace tarifNamespace
{
    public class carrier
    {
        private tarif tar;
        private string name = "A2";
        private int numOfUsers = 0;
        private static carrier carrierInstance = null;

        private carrier() { tar = new tarif(); }
        public static carrier getInstance()
        {
            if (carrierInstance == null)
                carrierInstance = new carrier();
            return carrierInstance;
        }
        public string getName() { return name; }
        public int getNumOfUsers() { return numOfUsers; }
        public int getPrice() { return tar.getPrice(); }
        public void setPrice(int price) { tar.setPrice(price); }
        public void addUser() { numOfUsers++; }
        public void removeUser() { if (numOfUsers > 0) numOfUsers--; }
        public int getProfit() { return numOfUsers * this.getPrice(); }

    }
    class tarif
    {
        private int price;
        public tarif() { price = 10; }
        public void setPrice(int price) { this.price = price; }
        public int getPrice() { return price; }
    }
}

namespace mainNamespace
{
    public static class mainClass
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Интернет оператор");
            carrier car = carrier.getInstance();
            int input;
            do
            {
                Console.Write("\n\n1) Текущая стоимость тарифа\n" +
                    "2) Наименоание оператора\n" +
                    "3) Число абонентов\n" +
                    "4) Подсчет выручки\n" +
                    "5) Добавить абонента\n" +
                    "6) Удалить абонента\n" +
                    "7) Изменить стоимость\n" +
                    "8) Выход\n" +
                    "Выберите действие: ");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("\nНеправильный ввод!\n");
                    Console.Write("\n\n1) Текущая стоимость тарифа\n" +
                    "2) Наименоание оператора\n" +
                    "3) Число абонентов\n" +
                    "4) Подсчет выручки\n" +
                    "5) Добавить абонента\n" +
                    "6) Удалить абонента\n" +
                    "7) Изменить стоимость\n" +
                    "8) Выход\n" +
                    "Выберите действие: ");
                }
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Стоимость: {0}$", car.getPrice());
                        break;
                    case 2:
                        Console.WriteLine("Оператор: {0}", car.getName());
                        break;
                    case 3:
                        Console.WriteLine("Число абонентов: {0}", car.getNumOfUsers());
                        break;
                    case 4:
                        Console.WriteLine("Выручка: {0}$", car.getProfit());
                        break;
                    case 5:
                        car.addUser();
                        Console.WriteLine("Aбонент добавлен!");
                        break;
                    case 6:
                        car.removeUser();
                        Console.WriteLine("Aбонент удален!");
                        break;
                    case 7:
                        int newPrice;
                        Console.Write("Введите новую стоимость: ");
                        while (!int.TryParse(Console.ReadLine(), out newPrice))
                        {
                            Console.Write("\nНеправильный ввод!\n");
                            Console.Write("Введите новую стоимость: ");
                        }
                        car.setPrice(newPrice);
                        break;
                    case 8:
                        Console.WriteLine("До свидания!");
                        break;
                    default:
                        Console.Write("\nНеправильный ввод!\n");
                        break;
                }
            } while (input != 8);
        }
    }
}