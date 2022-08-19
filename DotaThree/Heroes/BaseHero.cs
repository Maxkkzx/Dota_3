using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotaThree.Interfaces;

namespace DotaThree.Heroes
{
  //write interface and implement for BaseHero. In interface you need contain speak, Move, Attack
    public class BaseHero : ISkills
    {
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + " Сила: " + Strength + " Ловкость: " + Agility + " Интеллект: " + Intelligence;
        }

        public void Move()
        {
            Console.WriteLine("Герой идёт вперёд");
        } 

        public void Attack()
        {
            Console.WriteLine("Герой нанёс удар");
        }

        public void Speak()
        {
            Console.WriteLine("Х-а-а, а вот и я");
        }
    }
}
