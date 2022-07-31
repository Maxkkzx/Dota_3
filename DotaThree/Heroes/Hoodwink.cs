using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class Hoodwink : BaseHero
    {
       public Hoodwink()
        {
            Agility = 24;
            Strength = 17;
            Intelligence = 21;
            Name = "Hoodwink";
        }

        public void AcornShot()
        {
            Console.WriteLine("Hoodwink совершает атаку зарядив особый жёлудь");
        }

        public void Bushwhack()
        {
            Console.WriteLine("Hoodwink бросает сеть-ловушку и связывает врага с деревом");
        }

        public void Scurry()
        {
            Console.WriteLine("Hoodwink ускоряеться ловко обегая все препятствия");
        }

        public void Sharpshooter()
        {
            Console.WriteLine("Hoodwink заряжает мощный выстрел из своего арбалета");
        }
    }
}
