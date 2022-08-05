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
            Name = "Lion";
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

        public void Speak()
        {
            string[] Replic = new string[5] { "Я Lion", "В аду нет такой свирепости, как я", "Пошел ты к черту!", "Хах-ха-хе-хе-хе-хе-хе", "Ах, жаль вас разочаровывать" };

            Random rnd = new();
            Console.WriteLine(Replic[rnd.Next(0, 4)]);
        }
    }
}
