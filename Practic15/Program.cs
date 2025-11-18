using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Робот");

           
            robot.Work(); 
            robot.Work(); 
            robot.Charge(); 
            robot.Work(); 
        }
    }
}
