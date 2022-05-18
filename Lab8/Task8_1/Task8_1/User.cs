using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public int Trafic { get; set; } = 0;
        public Tarif Tarif { get; set; } = new TarifNoDiscount(String.Empty);
        public int fullPrice()
        {
            return Tarif.getPrice() * Trafic;
        }
    }
}
