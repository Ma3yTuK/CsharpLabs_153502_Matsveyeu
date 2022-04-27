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
        public statusType Status { get; set; } = statusType.regular;
        public int fullPrice()
        {
            return Tarif.Price * Trafic;
        }
        public enum statusType { vip, regular };
    }
}
