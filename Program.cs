Console.WriteLine("välkommen till fightclub");
Console.WriteLine("tryck ENTER för att starta");

Console.ReadLine();

Console.WriteLine("Vad heter du?");
string playerName = Console.ReadLine();

bool playAgian = true;

while (playAgian == true)
{
    Game(ref playAgian, ref playerName);
}

static void Game(ref bool playAgian, ref string playerName)
{


    int fighter1HP = 100;
    int fighter1ATK = Random.Shared.Next(5, 15);
    int fighter2HP = 100;
    int fighter2ATK = Random.Shared.Next(5, 15);


    while (fighter1HP > 0 && fighter2HP > 0)
    {
        fighter1HP -= fighter2ATK;
        fighter2HP -= fighter1ATK;

        Console.WriteLine($"{playerName} tog {fighter2ATK} skada och har {fighter1HP} liv kvar");
        Console.WriteLine($"fighetr 2 tog {fighter1ATK} skada och har {fighter2HP} liv kvar");

        fighter1ATK = Random.Shared.Next(5, 15);
        fighter2ATK = Random.Shared.Next(5, 15);

        Console.ReadLine();
    }

    if (fighter1HP > 0)

    {
        Console.WriteLine($"{playerName} Van");
    }
    else if (fighter2HP > 0)
    {
        Console.WriteLine("fighter 2 Van");
    }
    else
    {
        Console.WriteLine("ingen Van");
    }

    Console.WriteLine("Vill du spela igen? Y/N");
    string agian = Console.ReadLine();

    while (agian != "Y" && agian != "N")
    {
        Console.WriteLine("Skriv ett stort Y eller N");
        agian = Console.ReadLine();
    }

    if (agian == "Y")
    {
        playAgian = true;
    }
    else if (agian == "N")
    {
        playAgian = false;
    }

}