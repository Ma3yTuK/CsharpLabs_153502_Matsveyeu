// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Enter first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            c = a / b;
            Console.Write("Result of division: {0}", c);
        }
    }
}
