﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class Medusa : BaseHero
    {
        public Medusa()
        {
            Agility = 22;
            Intelligence = 23;
            Strength = 17;
            Name = "Medusa";
        }

        public  void SplitShot()
        {
            Console.WriteLine("Medusa магически расщепляет свои стрелы, атакуя несколько целей");
        }

        public  void MysticSnake()
        {
            Console.WriteLine("Medusa выпустила энергетическую змею");
        }

        public  void ManaShield()
        {
            Console.WriteLine("Medusa создала энергетический щит");
        }

        public  void StoneGaze()
        {
            Console.WriteLine("Medusa превращяет врагов в камень");
        }

        public void Speak()
        {
            string[] Replic = new string[5] { "Medusa!", "Встреться со мной взглядом", "Ради чести", "Бесшумный, как змея", "Стой где стоишь" };

            Random rnd = new();
            Console.WriteLine(Replic[rnd.Next(0, 4)]);
        }
    }
}
