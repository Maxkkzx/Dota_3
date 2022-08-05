namespace DotaThree.Heroes
{
    public class Pudge : BaseHero
    {
        public Pudge()
        {
            Agility = 25;
            Strength = 14;
            Intelligence = 16;
            Name = "Pudge";
        }

        public void Hook()
        {
            Console.WriteLine("Pudge Бросил мясной крюк");

            Random random = new();

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

        public void Speak()
        {
            string[] Replic = new string[5] { "За дело берётся Мясник", "Р-р-расчехляю ножи!", "Сожру с потрохами!", "А ну быстро сюда!", "Ха-ха! Свежее мясо!" };

            Random rnd = new();
            Console.WriteLine(Replic[rnd.Next(0, 4)]);
        }
    }
}
