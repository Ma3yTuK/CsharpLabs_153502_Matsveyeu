using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class User
    {
        public string Name { get; set; } = string.Empty;
        public int Trafic { get; set; } = 0;
        public Tarif Tarif { get; set; } = new Tarif();
        public int fullPrice()
        {
            return Tarif.Price * Trafic;
        }
    }
}
