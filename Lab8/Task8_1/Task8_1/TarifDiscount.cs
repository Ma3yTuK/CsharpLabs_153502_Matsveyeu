using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TarifDiscount : Tarif
    {
        public string Name { get; set; }
        private int price;
        private int discount;

        public TarifDiscount(string Name, int price = 0, int discount = 0)
        {
            if (price >= 0 && discount >= 0 && price-discount >=0)
            {
                this.price = price;
                this.discount = discount;
            }
            else
            {
                this.price = 0;
                this.discount = 0;
            }
            this.Name = Name;
        }

        public int getPrice()
        {
            return price - discount;
        }
    }
}