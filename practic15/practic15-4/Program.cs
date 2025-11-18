using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAttack> attackers = new List<IAttack>()
        {
            new Warrior(),
            new Mage()
        };

            List<IHeal> healers = new List<IHeal>()
        {
            new Mage()
        };

            Console.WriteLine("Персонажи, умеющие атаковать:");
            foreach (var attacker in attackers)
            {
                attacker.Attack();
            }
            Console.WriteLine();
            Console.WriteLine("Персонажи, умеющие лечить:");
            foreach (var healer in healers)
            {
                healer.Heal();
            }
        }
    }
}
