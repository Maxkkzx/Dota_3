using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class Lina : BaseHero
    {
        public Lina()
        {
            Agility = 23;
            Strength = 20;
            Intelligence = 30;
        }

        public void DragonSlave()
        {
            Console.WriteLine("Lina высвобождает дыхание дракона");
        }

        public void LightStrikeArray()
        {
            Console.WriteLine("Lina призывает стоб пламени");
        }

        public void LagunaBlade()
        {
            Console.WriteLine("Lina выпускает разряд молнии в врага");
        }
    }
}
