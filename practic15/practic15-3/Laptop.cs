using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_3
{
    public class Laptop : IPricable
    {
        private decimal price;

        public Laptop(decimal price)
        {
            this.price = price;
        }

        public decimal GetPrice()
        {
            return price;
        }
    }

}
