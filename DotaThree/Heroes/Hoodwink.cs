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

        public void Speak()
        {
            string[] Replic = new string[5] { "Кто сказал, что ты можешь гулять в моем лесу?", "Поздоровайся с моим маленьким другом", "Справедливо, что тебе есть о чем беспокоиться", "С кем мы сражаемся?", "Эй, как ты там?" };

            Random rnd = new();
            Console.WriteLine(Replic[rnd.Next(0, 4)]);
        }
    }
}
