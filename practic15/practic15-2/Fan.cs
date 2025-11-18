using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_2
{
    public class Fan : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Вентилятор включен.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Вентилятор выключен.");
        }
    }
}
