using System;

namespace Task7_1
{
    public class Task {
        public static void Main()
        {
            Circle circle1 = new Circle(1, 1, 1);
            Circle circle2 = new Circle(0, 0, 0);
            circle1.X = 2;
            circle1.Y = 2;
            circle1.Radius = 2;
            Circle circle3 = circle1 + 2.3;
            double res = (double)circle1 - 2.3;
            double square2 = circle2.Square();
            double perimetr1 = circle1.Perimetr();
            Console.WriteLine("Circle 1: {0}, {1}, {2}. Perimetr: {3}", circle1.X, circle1.Y, circle1.Radius, perimetr1);
            Console.WriteLine("Circle 2: {0}, {1}, {2}. Square: {3}", circle2.X, circle2.Y, circle2.Radius, square2);
            Console.WriteLine("Circle1 radius - 2.3: {0}", res);
        }
    }
}
