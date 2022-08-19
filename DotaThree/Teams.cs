using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotaThree.Heroes;
using DotaThree.Interfaces;

namespace DotaThree.Heroes
{
    public class Teams
    {
        List<BaseHero> DireTeam { get; set; }

        List<BaseHero> RadiantTeam { get; set; }

        public void TeamMix()
        {
            RadiantTeam = new List<BaseHero>(5);
            DireTeam = new List<BaseHero>(5);
        }
    }
}
