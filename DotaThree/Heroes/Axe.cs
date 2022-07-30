using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class Axe : BaseHero
    {
        public Axe()
        {
            Agility = 20;
            Strength = 25;
            Intelligence = 18;
        }

        public void BerserkersCall()
        {
            Console.WriteLine("Axe бросает вызов ближайшим врагам");
        }

        public void BattleHunger()
        {
            Console.WriteLine("Axe приводит врага в бешенство");
        }

        public void CullingBlade()
        {
            Console.WriteLine("Axe наносит удар по слабой точке врага");
        }
    }
}
