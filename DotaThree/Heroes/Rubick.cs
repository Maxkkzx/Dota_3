using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class Rubick : BaseHero
    {
        public Rubick()
        {
            Agility = 23;
            Strength = 21;
            Intelligence = 25;
            Name = "Rubick";
        }

        public void Telekinesis()
        {
            Console.WriteLine("Rubick ненадолго поднимает врага в воздух");
        }

        public void FadeBolt()
        {
            Console.WriteLine("Rubick создает мощный поток магической энергии");
        }

        public void SpellSteal()
        {
            Console.WriteLine("Rubick ворует способность у врага");
        }
    }
}
