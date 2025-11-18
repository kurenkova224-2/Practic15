using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPricable> products = new List<IPricable>
        {
            new Phone(700.0m, 24),
            new Laptop(1200.0m),  
            new Phone(500.0m, 12)  
        };

            decimal totalCost = 0.0m;

            foreach (var product in products)
            {
                totalCost += product.GetPrice(); 

                if (product is IWarranty warranty)
                {
                    Console.WriteLine($"Срок гарантии: {warranty.GetWarrantyPeriod()} месяцев");
                }
            }

            Console.WriteLine($"Общая стоимость товаров: {totalCost:F2}");
        }
    }
}

