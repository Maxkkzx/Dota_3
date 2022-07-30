using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class Terrorblade : BaseHero
    {
        public Terrorblade()
        {
            Agility = 22;
            Strength = 16;
            Intelligence = 19;
        }

        public void Reflection()
        {
            Console.WriteLine("Terrorblade создал тёмного неуязвимого двойника противника");
        }

        public void ConjureImage()
        {
            Console.WriteLine("Terrorblade создал копию самого себя");
        }

        public void Metamorphosis()
        {
            Console.WriteLine("Terrorblade превратился в могущественного демона");
        }

        public void Sunder()
        {
            Console.WriteLine("Terrorblade поменялся жизнеными силами");
        }
    }
}
