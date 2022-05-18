using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface Tarif
    {
        string Name { get; set; }
        int getPrice();
    }
}