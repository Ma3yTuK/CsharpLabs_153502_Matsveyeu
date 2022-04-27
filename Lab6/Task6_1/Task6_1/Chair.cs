using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    public sealed class Chair : Furniture
    {
        public override string Model { get; set; } = string.Empty;
        public new void fold() { base.fold(); }
        public new void unfold() { base.unfold(); }
        public void order(int num) { Console.WriteLine("{0} items ordered!", num); }
    }
}
