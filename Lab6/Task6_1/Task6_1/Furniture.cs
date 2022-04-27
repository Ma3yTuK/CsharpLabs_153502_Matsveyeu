using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    public abstract class Furniture
    {
        public Furniture() { Console.WriteLine("Furniture created!"); }
        abstract public string Model { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        virtual public double area() { return Length*Height; }
        public void fold() { Console.WriteLine("Folding completed!"); }
        public void unfold() { Console.WriteLine("Unfolding completed!"); }
        public void order() { Console.WriteLine("Item ordered!"); }
    }
}
