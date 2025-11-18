using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_4
{
    interface IAttack
    {
        void Attack();
    }

    interface IHeal
    {
        void Heal();
    }

   public class Warrior : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Воин атакует врага!");
        }
    }

}
