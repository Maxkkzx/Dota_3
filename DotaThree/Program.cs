class Hero
{
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
    public static void Move()
    {
        Console.WriteLine("Герой идёт вперёд");
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
        Console.WriteLine("Pudge Бросил мясной крюк");
        if (Random() >= 3)
        {
            Console.WriteLine("Pudge попал в цель");
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
        Console.WriteLine("Pudge начал заживо пожирать врага");
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
        Console.WriteLine("Terrorblade создал тёмного неуязвимого двойника противника");
    }
    public static void ConjureImage()
    {
        Console.WriteLine("Terrorblade создал копию самого себя");
    }
    public static void Metamorphosis()
    {
        Console.WriteLine("Terrorblade превратился в могущественного демона");
    }
    public static void Sunder()
    {
        Console.WriteLine("Terrorblade поменялся жизнеными силами");
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
        Console.WriteLine("Medusa магически расщепляет свои стрелы, атакуя несколько целей");
    }
    public static void MysticSnake()
    {
        Console.WriteLine("Medusa выпустила энергетическую змею");
    }
    public static void ManaShield()
    {
        Console.WriteLine("Medusa создала энергетический щит");
    }
    public static void StoneGaze()
    {
        Console.WriteLine("Medusa превращяет врагов в камень");
    }
}
class StormSpirit : Hero
{
    public static void Atribute()
    {
        StormSpirit stormSpirit = new StormSpirit();
        stormSpirit.Agility = 22;
        stormSpirit.Strength = 21;
        stormSpirit.Intelligence = 23;
        Console.WriteLine($"Сила: {stormSpirit.Strength}  Ловкость: {stormSpirit.Agility}  Интеллект: {stormSpirit.Intelligence}");
    }
    public static void StaticRemnant()
    {
        Console.WriteLine("Storm Spirit оставил свою энергетическую копию");
        Console.WriteLine("Атака Storm Spirit заряжена энергией");
    }
    public static void ElectricVortex()
    {
        Console.WriteLine("Storm Spirit затянул врага в свой электрический вихрь");
        Console.WriteLine("Атака Storm Spirit заряжена энергией");
    }
    public static void BallLightning()
    {
        Console.WriteLine("Strom Spirit летит вперёд");
        Console.WriteLine("Атака Storm Spirit заряжена энергией");
    }
}
class Lion : Hero
{
    public static void Atribute()
    {
        Lion lion = new Lion();
        lion.Agility = 16;
        lion.Strength = 17;
        lion.Intelligence = 16;
        Console.WriteLine($"Сила: {lion.Strength}  Ловкость: {lion.Agility}  Интеллект: {lion.Intelligence}");
    }
    public static void EarthSpike()
    {
        Console.WriteLine("Lion выпустил полосу каменных шипов");
    }
    public static void Hex()
    {
        Console.WriteLine("Lion превратил врага в безобидную зверушку");
    }
    public static void ManaDrain()
    {
        Console.WriteLine("Lion поглащает магическую силу врага");
    }
    public static void FingerofDeath()
    {
        Console.WriteLine("Lion разрывает врага огненным зарядом");
    }
}
class CrystalMaiden : Hero
{
    public static void Atribute()
    {
        CrystalMaiden crystalMaiden = new CrystalMaiden();
        crystalMaiden.Agility = 16;
        crystalMaiden.Strength = 17;
        crystalMaiden.Intelligence = 16;
        Console.WriteLine($"Сила: {crystalMaiden.Strength}  Ловкость: {crystalMaiden.Agility}  Интеллект: {crystalMaiden.Intelligence}");
    }
    public static void CrystalNova()
    {
        Console.WriteLine("Crystal Maiden направляет морозный ветер в врага");
    }
    public static void Frostbite()
    {
        Console.WriteLine("Crystal Maiden заковывает противника в лёд");
    }
    public static void FreezingField()
    {
        Console.WriteLine("Вокруг Crystal Maiden смертельные сосульки");
    }
}
class Lina : Hero
{
    public static void Atribute()
    {
        Lina lina = new Lina();
        lina.Agility = 23;
        lina.Strength = 20;
        lina.Intelligence = 30;
        Console.WriteLine($"Сила: {lina.Strength}  Ловкость: {lina.Agility}  Интеллект: {lina.Intelligence}");
    }
    public static void DragonSlave()
    {
        Console.WriteLine("Lina высвобождает дыхание дракона");
    }
    public static void LightStrikeArray()
    {
        Console.WriteLine("Lina призывает стоб пламени");
    }
    public static void LagunaBlade()
    {
        Console.WriteLine("Lina выпускает разряд молнии в врага");
    }
}

