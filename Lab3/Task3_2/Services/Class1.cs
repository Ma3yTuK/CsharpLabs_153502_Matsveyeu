using System;

namespace MyNamespace
{
    public class Calc
    {
        public static double MyFunc(double z, double b)
        {
            double x, y;
            if (z < 0 + 1e-9)
            {
                x = Math.Pow(z, b) + Math.Abs(b / 2);
                Console.WriteLine("Выполнилась первая ветка!");
            }
            else {
                x = Math.Sqrt(z);
                Console.WriteLine("Выполнилась вторая ветка!");
            }
            y = 1 / Math.Cos(x) + Math.Log(Math.Abs(Math.Tan(x / 2)));
            Console.WriteLine("Результат: {0}", y);
            return y;
        }
    }
}