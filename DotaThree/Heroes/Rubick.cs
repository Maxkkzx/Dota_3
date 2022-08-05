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

        public void Speak()
        {
            string[] Replic = new string[5] { "Потрясающая энергия!", "Маг наносит удар", "Я Rubick, Великий маг", "Мою жажду знаний невозможно утолить", "Ха-ха-ха! Ах, хи-хи-хи-хи-хи-хи-хи-хи-хи!" };

            Random rnd = new();
            Console.WriteLine(Replic[rnd.Next(0, 4)]);
        }
    }
}
