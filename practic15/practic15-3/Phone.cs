using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_3
{
    public interface IPricable
    {
        decimal GetPrice();
    }

    public interface IWarranty
    {
        int GetWarrantyPeriod();
    }

    public class Phone : IPricable, IWarranty
    {
        private decimal price;
        private int warrantyMonths;

        public Phone(decimal price, int warrantyMonths)
        {
            this.price = price;
            this.warrantyMonths = warrantyMonths;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public int GetWarrantyPeriod()
        {
            return warrantyMonths;
        }
    }

}
