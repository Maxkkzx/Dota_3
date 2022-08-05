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
            Name = "Terrorblade";
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

        public void Speak()
        {
            string[] Replic = new string[5] { "Terrorblade!", "Испытай мой клинок, почему бы тебе этого не сделать", "Я двигаю небо и землю", "Мудрый клинок забирает жизнь глупца", "Ярость демона сильнее смерти" };

            Random rnd = new();
            Console.WriteLine(Replic[rnd.Next(0, 4)]);
        }
    }
}
