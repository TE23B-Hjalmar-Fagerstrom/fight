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
    int fighetr1StunChans = 1;
    int fighter2HP = 100;
    int fighetr2StunChans = 1;


    while (fighter1HP > 0 && fighter2HP > 0)
    {

        int fighter1ATK = Random.Shared.Next(5, 15);
        int fighter2ATK = Random.Shared.Next(5, 15);
        int whoStart = Random.Shared.Next(1, 3);

        if (whoStart <= 1)
        {
            if (fighter1HP > 0 && fighetr2StunChans != 5)
            {
                fighter2HP -= fighter1ATK;
                Console.WriteLine($"fighetr 2 tog {fighter1ATK} skada och har {fighter2HP} liv kvar");
                fighetr1StunChans = Random.Shared.Next(1, 6);
                if (fighetr1StunChans == 5 && fighetr2StunChans != 5)
                {
                    Console.WriteLine("och blev stunad");
                }
            }

            if (fighter2HP > 0 && fighetr1StunChans != 5)
            {
                fighter1HP -= fighter2ATK;
                Console.WriteLine($"{playerName} tog {fighter2ATK} skada och har {fighter1HP} liv kvar");
                fighetr2StunChans = Random.Shared.Next(1, 6);
                if (fighetr1StunChans != 5 && fighetr2StunChans == 5)
                {
                    Console.WriteLine("och blev stunad");
                }
            }
        }

        if (whoStart >= 2)
        {
            if (fighter2HP > 0 && fighetr1StunChans != 5)
            {
                fighter1HP -= fighter2ATK;
                Console.WriteLine($"{playerName} tog {fighter2ATK} skada och har {fighter1HP} liv kvar");
                fighetr2StunChans = Random.Shared.Next(1, 6);
                if (fighetr2StunChans == 5 && fighetr1StunChans != 5)
                {
                    Console.WriteLine("och blev stunad");
                }
            }

            if (fighter1HP > 0 && fighetr2StunChans != 5)
            {
                fighter2HP -= fighter1ATK;
                Console.WriteLine($"fighetr 2 tog {fighter1ATK} skada och har {fighter2HP} liv kvar");
                fighetr1StunChans = Random.Shared.Next(1, 6);
                if (fighetr1StunChans == 5 && fighetr2StunChans != 5)
                {
                    Console.WriteLine("och blev stunad");
                }
            }
        }




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