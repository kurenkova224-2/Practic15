using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic15
{
    public interface IWorkable
    {
        void Work();
    }

    public interface IChargeable
    {
        void Charge();
    }

    public class Robot : IWorkable, IChargeable
    {
        public string Name { get; private set; }
        private int energy;

        public Robot(string name)
        {
            Name = name;
            energy = 100; 
        }

        public void Work()
        {
            if (energy >= 20)
            {
                energy -= 20;
                Console.WriteLine($"{Name} работает. Текущая энергия: {energy}");
            }
            else
            {
                Console.WriteLine($"{Name} недостаточно энергии для работы.");
            }
        }

        public void Charge()
        {
            if (energy <= 50)
            {
                energy += 50;
                if (energy > 100) energy = 100; 
                Console.WriteLine($"{Name} заряжается. Текущая энергия: {energy}");
            }
            else
            {
                Console.WriteLine($"{Name} не нуждается в зарядке.");
            }
        }

    }
}
