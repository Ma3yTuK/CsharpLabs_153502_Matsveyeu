using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TarifNoDiscount : Tarif
    {
        public string Name { get; set; }
        private int price;

        public TarifNoDiscount(string Name, int price = 0)
        {
            if (price >= 0)
            {
                this.price = price;
            }
            else
            {
                this.price = 0;
            }
            this.Name = Name;
        }

        public int getPrice()
        {
            return price;
        }
    }
}
