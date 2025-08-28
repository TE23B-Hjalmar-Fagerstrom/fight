
while (true)
{
    Game();
}

static void Game()
{

    int fighter1HP = 100;
    int fighter1ATK = Random.Shared.Next(5, 15);
    int fighter2HP = 100;
    int fighter2ATK = Random.Shared.Next(5, 15);

    Console.WriteLine("välkommen till fightclub");

    Console.WriteLine("tryck ENTER för att starta");

    Console.ReadLine();

    while (fighter1HP > 0 && fighter2HP > 0)
    {
        fighter1HP -= fighter2ATK;
        fighter2HP -= fighter1ATK;

        Console.WriteLine($"fighetr 1 tog {fighter2ATK} skada och har {fighter1HP} liv kvar");
        Console.WriteLine($"fighetr 2 tog {fighter1ATK} skada och har {fighter2HP} liv kvar");

        fighter1ATK = Random.Shared.Next(5, 15);
        fighter2ATK = Random.Shared.Next(5, 15);

        Console.ReadLine();
    }

    if (fighter1HP > 0)

    {
        Console.WriteLine("fighter 1 Van");
    }
    else if (fighter2HP > 0)
    {
        Console.WriteLine("fighter 2 Van");
    }
    else
    {
        Console.WriteLine("ingen Van");
    }
    Console.ReadLine();
}