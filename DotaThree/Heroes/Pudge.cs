namespace DotaThree.Heroes
{
    public class Pudge : BaseHero
    {
        public Pudge()
        {
            Agility = 25;
            Strength = 14;
            Intelligence = 16;
        }

        public void Hook()
        {
            Console.WriteLine("Pudge Бросил мясной крюк");
            Random random = new Random();
            if (random.Next(0, 5) >= 3)
            {
                Console.WriteLine("Pudge попал в цель");
            }
            else
            {
                Console.WriteLine("Ах ты мелкий...");
            }
        }

        public void Root()
        {
            Console.WriteLine("Ядовитое облако появилось вокруг Pudge");
        }

        public void Dismember()
        {
            Console.WriteLine("Pudge начал заживо пожирать врага");
        }
    }
}
