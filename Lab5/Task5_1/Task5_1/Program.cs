using System;
using Classes;

namespace Task5_1
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            Provider provider = new Provider();
            provider.tarifInput("First", 10);
            provider.tarifInput("Second", 5);
            provider.tarifInput("Third", 15);
            provider.tarifInput("Fourth", 10);
            provider.register("First", "First", 10);
            provider.register("Second", "Second", 5);
            provider.register("Third", "Third", 15);
            provider.register("Fourth", "Fourth", 10);
            Console.WriteLine("First user trafic: {0}", provider.userTrafic("First"));
            Console.WriteLine("Full profit: {0}", provider.profit());
            Console.WriteLine("Spent the most: {0}", provider.mainUser());
        }
    }
}
