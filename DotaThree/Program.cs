using DotaThree.Heroes;

namespace DotaThree 
{
    public class Program 
    {  
        static void Main(string[] args)
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

            Console.WriteLine(pudge);
        }
    }    
}
