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
            Name = "Lina";
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

        public void Speak()
        {
            string[] Replic = new string[5] { "Хочешь поиграть с огнём?", "Разожжём пожар!", "Мечом и пламенем!", "Беги, если сможешь", "Теперь тебе тепло?" };

            Random rnd = new();
            Console.WriteLine(Replic[rnd.Next(0, 4)]);
        }
    }
}
