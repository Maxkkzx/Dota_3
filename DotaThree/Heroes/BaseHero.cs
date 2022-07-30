using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Heroes
{
    public class BaseHero
    {
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        
        public void Move()
        {
            Console.WriteLine("Герой идёт вперёд");
        }

        public void Attack()
        {
            Console.WriteLine("Герой нанёс удар");
        }
    }
}
