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
            Name = "Axe";
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

        public void Speak()
        {
            string[] Replic = new string[5] { "Axe готов!", "Пусть начнется бойня", "Axe идёт!", "Попробуй моё лезвие!", "Приходи и получи его!" };

            Random rnd = new();
            Console.WriteLine(Replic[rnd.Next(0, 4)]);
        }
    }
}
