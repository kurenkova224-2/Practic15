using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic15_2
{
    public interface ISwitchable
    {
        void TurnOn();
        void TurnOff();
    }

    public interface ISettable
    {
        void SetLevel(int level);
    }

    public class Lamp : ISwitchable, ISettable
    {
        private int level;

        public void TurnOn()
        {
            level = 100;
            Console.WriteLine("Лампа включена. Уровень яркости: 100.");
        }

        public void TurnOff()
        {
            level = 0;
            Console.WriteLine("Лампа выключена. Уровень яркости: 0.");
        }

        public void SetLevel(int level)
        {
            if (level < 0 || level > 100)
            {
                Console.WriteLine("Уровень должен быть в диапазоне от 0 до 100.");
            }
            else
            {
                this.level = level;
                Console.WriteLine($"Уровень яркости установлен на {level}.");
            }
        }
    }
}
