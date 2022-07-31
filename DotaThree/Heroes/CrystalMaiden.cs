using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class CrystalMaiden : BaseHero
    {
        public CrystalMaiden()
        {
            Agility = 16;
            Strength = 17;
            Intelligence = 16;
            Name = "Crystal Maiden";
        }

        public void CrystalNova()
        {
            Console.WriteLine("Crystal Maiden направляет морозный ветер в врага");
        }

        public void Frostbite()
        {
            Console.WriteLine("Crystal Maiden заковывает противника в лёд");
        }

        public void FreezingField()
        {
            Console.WriteLine("Вокруг Crystal Maiden падают смертельные сосульки");
        }
    }

}
