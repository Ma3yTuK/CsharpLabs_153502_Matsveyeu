using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    public sealed class RoundTable : Furniture
    {
        public override string Model { get; set; } = string.Empty;
        public double Radius { get; set; }
        public override double area() { return Math.PI * Radius * Radius; }
    }
}
