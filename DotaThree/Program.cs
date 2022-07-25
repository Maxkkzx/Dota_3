class Hero
{
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
class Invoker : Hero
{
    
}


