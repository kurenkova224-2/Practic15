using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> devices = new List<ISwitchable>
        {
            new Lamp(), 
            new Fan()   
        };

            
            foreach (var device in devices)
            {
                device.TurnOn();
                device.TurnOff();
            }

            Lamp lamp = new Lamp();
            lamp.TurnOn(); 
            lamp.SetLevel(30); 
            lamp.TurnOff(); 
        }
    }
}
