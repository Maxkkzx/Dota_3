Pudge.Hook();
class Hero
{
    public int Strength = 20;
    public int Agility = 15;
    public int Intelligence = 15; 
    public static void Move()
    {
        Console.WriteLine("Герой идёт вперёд!");
    }
    public static void Attack()
    {
        Console.WriteLine("Герой нанёс удар");
    }
    public static int Random()
    {
        Random r = new();
        int randomIndex = r.Next(0, 5);
        return randomIndex;
    }
}
class Pudge : Hero
{
    public static void Hook()
    {
        Console.WriteLine("Pudge Бросил мясной крюк!");
        if(Random() >= 3)
        {
            Console.WriteLine("Pudge попал в цель!");
        }
        else
        {
            Console.WriteLine("Ах ты мелкий...");
        }
    }
    public static void Root()
    {
        Console.WriteLine("Ядовитое облако появилось вокруг Pudge");
    }
    public static void Dismember()
    {
        Console.WriteLine("Pudge начинает заживо пожирать врага");
    }
}


