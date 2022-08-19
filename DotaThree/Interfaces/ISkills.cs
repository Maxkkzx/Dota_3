using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaThree.Interfaces
{
    interface ISkills
    {
        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public string Name { get; set; }

        void Attack();

        void Move();

        void Speak();
    }
}
