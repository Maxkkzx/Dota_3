using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class StormSpirit : BaseHero
    {
        public StormSpirit()
        {
            Agility = 22;
            Strength = 21;
            Intelligence = 23;
            Name = "Strom Spirit";
        }

        public void StaticRemnant()
        {
            Console.WriteLine("Storm Spirit оставил свою энергетическую копию");
            Console.WriteLine("Атака Storm Spirit заряжена энергией");
        }

        public void ElectricVortex()
        {
            Console.WriteLine("Storm Spirit затянул врага в свой электрический вихрь");
            Console.WriteLine("Атака Storm Spirit заряжена энергией");
        }

        public void BallLightning()
        {
            Console.WriteLine("Strom Spirit летит вперёд");
            Console.WriteLine("Атака Storm Spirit заряжена энергией");
        }

        public void Speak()
        {
            string[] Replic = new string[5] { "Штормовое предупреждение", "О-о, это кто такой красивый?", "Шторм начинается!", "Да пребудет с вами Дух Бури!", "Storm Spirit прибыл!" };

            Random rnd = new();
            Console.WriteLine(Replic[rnd.Next(0, 4)]);
        }
    }
}
