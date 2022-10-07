using DotaThree.Heroes;
using DotaThree.Class;

namespace DotaThree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Teams team = new Teams();
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

            axe.BerserkersCall();
            crystalMaiden.FreezingField();
            hoodwink.AcornShot();
            lina.LagunaBlade();
            lion.FingerofDeath();
            medusa.MysticSnake();
            pudge.Hook();
            rubick.SpellSteal();
            stormSpirit.ElectricVortex();
            terrorblade.Metamorphosis();

            axe.Speak();
            crystalMaiden.Speak();
            hoodwink.Speak();
            lina.Speak();
            lion.Speak();
            medusa.Speak();
            pudge.Speak();
            rubick.Speak();
            stormSpirit.Speak();
            terrorblade.Speak();

            team.TeamMix();

            Console.WriteLine(pudge);
        }
    }
}
