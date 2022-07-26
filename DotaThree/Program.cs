﻿class Hero
{
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
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
    public static void Atribute()
    {
        Pudge pudge = new Pudge();
        pudge.Agility = 25;
        pudge.Strength = 14;
        pudge.Intelligence = 16;
        Console.WriteLine($"Сила: {pudge.Strength}  Ловкость: {pudge.Agility}  Интеллект: {pudge.Intelligence}");
    }
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
        Console.WriteLine("Ядовитое облако появилось вокруг Pudge!");
    }
    public static void Dismember()
    {
        Console.WriteLine("Pudge начал заживо пожирать врага!");
    }
}
class Terrorblade : Hero
{ 
    public static void Atribute()
    {
        Terrorblade terrorblade = new Terrorblade();
        terrorblade.Agility = 22;
        terrorblade.Strength = 16;
        terrorblade.Intelligence = 19;
        Console.WriteLine($"Сила: {terrorblade.Strength}  Ловкость: {terrorblade.Agility}  Интеллект: {terrorblade.Intelligence}");
    }
    public static void Reflection()
    {
        Console.WriteLine("Terrorblade создал тёмного неуязвимого двойника противника!");
    }
    public static void ConjureImage()
    {
        Console.WriteLine("Terrorblade создал копию самого себя");
    }
    public static void Metamorphosis()
    {
        Console.WriteLine("Terrorblade превратился в могущественного демона!");
    }
    public static void Sunder()
    {
        Console.WriteLine("Terrorblade поменялся жизнеными силами!");
    }
}

class Medusa : Hero
{
    public static void Atribute()
    {
        Medusa medusa = new Medusa();
        medusa.Agility = 22;
        medusa.Strength = 17;
        medusa.Intelligence = 23;
        Console.WriteLine($"Сила: {medusa.Strength}  Ловкость: {medusa.Agility}  Интеллект: {medusa.Intelligence}");
    }
    public static void SplitShot()
    {
        Console.WriteLine("Medusa магически расщепляет свои стрелы, атакуя несколько целей!");
    }
    public static void MysticSnake()
    {
        Console.WriteLine("Medusa выпустила энергетическую змею!");
    }
    public static void ManaShield()
    {
        Console.WriteLine("Medusa создала энергетический щит!");
    }
    public static void StoneGaze()
    {
        Console.WriteLine("Medusa превращяет врагов в камень!");
    }
}


