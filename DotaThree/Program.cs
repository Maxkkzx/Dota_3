using DotaThree.Heroes;

namespace DotaThree 
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Axe axe = new Axe();
            CrystalMaiden crystalMaiden = new CrystalMaiden();
            Hoodwink hoodwink = new Hoodwink();
            Lina lina = new Lina();
            Lion lion = new Lion();
            Medusa medusa = new Medusa();
            Pudge pudge = new Pudge();
            Rubick rubick = new Rubick();
            StormSpirit stormSpirit = new StormSpirit();
            Terrorblade terrorblade = new Terrorblade();

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
        }
    }    
}
