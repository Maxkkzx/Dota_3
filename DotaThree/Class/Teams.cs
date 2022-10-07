using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotaThree.Heroes;
using DotaThree.Interfaces;

namespace DotaThree.Class
{
    public class Teams
    {

        BaseHero[] DireTeam = new BaseHero[5];
        BaseHero[] RadiantTeam = new BaseHero[5];

        public void TeamMix()
        {
            Axe axe = new();
            CrystalMaiden crystalMaiden = new();
            Hoodwink hoodwink = new();
            Lina lina = new();
            Lion lion = new();
            Medusa medusa = new();
            Pudge pudge = new();
            Rubick rubick = new();
            StormSpirit stormSpirit = new();
            Terrorblade terrorblade = new();

            List<BaseHero> myHero = new List<BaseHero>(10) { axe, crystalMaiden, hoodwink, lina, lion, medusa, pudge, rubick, stormSpirit, terrorblade };
            myHero.Shuffle();

            myHero.CopyTo(0, DireTeam, 0, 5);
            myHero.CopyTo(5, RadiantTeam, 0, 5);
        }
    }
}
