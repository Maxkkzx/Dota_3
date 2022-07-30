using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class Lion : BaseHero
    {
        public Lion()
        {
            Agility = 16;
            Strength = 17;
            Intelligence = 16;
        }

        public void EarthSpike()
        {
            Console.WriteLine("Lion выпустил полосу каменных шипов");
        }

        public void Hex()
        {
            Console.WriteLine("Lion превратил врага в безобидную зверушку");
        }

        public void ManaDrain()
        {
            Console.WriteLine("Lion поглащает магическую силу врага");
        }

        public void FingerofDeath()
        {
            Console.WriteLine("Lion разрывает врага огненным зарядом");
        }
    }
}
