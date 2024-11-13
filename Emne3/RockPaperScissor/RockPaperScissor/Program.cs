static string ComputerChoise()
{
    var random = new Random();
    int number = random.Next(1,3);
    
    if(number == 1){return "stein";} 
    if(number == 2) {return "papir";}
    if(number == 3) {return "saks";}

    return null;
}

int ComputerCount = 0;
int PlayerCount = 0;

string ComputerRandom = ComputerChoise();

PlayGame(ComputerRandom);

void PlayGame(string ComputerRandom) {
    
    Console.WriteLine("Gjør et valg skriv (stein, papir eller saks)");
    string myChoise = Console.ReadLine();


    if (myChoise == "stein")
    {
        if (ComputerRandom == "stein")
        {
            Console.WriteLine($"Du valgte {myChoise} og dataen valgte {ComputerRandom} Det ble uavgjort");
            Console.WriteLine($"Du har {PlayerCount} poeng! og dataen har {ComputerCount} poeng!");

        }

        if (ComputerRandom == "papir")
        {
            Console.WriteLine($"Du valgte {myChoise} og dataen valgte {ComputerRandom} du tapte");
            ComputerCount++;
            Console.WriteLine($"Du har {PlayerCount} poeng! og dataen har {ComputerCount} poeng!");
        }
        if (ComputerRandom == "saks")
        {
            Console.WriteLine($"Du valgte {myChoise} og dataen valgte {ComputerRandom} du VANT!");
            PlayerCount++;
            Console.WriteLine($"Du har {PlayerCount} poeng! og dataen har {ComputerCount} poeng!");
        }

        ComputerRandom = ComputerChoise();
        PlayGame(ComputerRandom);
    }  
    if (myChoise == "papir")
    {
        if (ComputerRandom == "papir")
        {
            Console.WriteLine($"Du valgte {myChoise} og dataen valgte {ComputerRandom} Det ble uavgjort");
            Console.WriteLine($"Du har {PlayerCount} poeng! og dataen har {ComputerCount} poeng!");
        }

        if (ComputerRandom == "saks")
        {
            Console.WriteLine($"Du valgte {myChoise} og dataen valgte {ComputerRandom} du tapte");
            ComputerCount++;
            Console.WriteLine($"Du har {PlayerCount} poeng! og dataen har {ComputerCount} poeng!");
        }
        if (ComputerRandom == "stein")
        {
            Console.WriteLine($"Du valgte {myChoise} og dataen valgte {ComputerRandom} du VANT!");
            PlayerCount++;
            Console.WriteLine($"Du har {PlayerCount} poeng! og dataen har {ComputerCount} poeng!");
        }

        ComputerRandom = ComputerChoise();
        PlayGame(ComputerRandom);
    }  
    if (myChoise == "saks")
    {
        if (ComputerRandom == "saks")
        {
            Console.WriteLine($"Du valgte {myChoise} og dataen valgte {ComputerRandom} Det ble uavgjort");
            Console.WriteLine($"Du har {PlayerCount} poeng! og dataen har {ComputerCount} poeng!");
        }

        if (ComputerRandom == "stein")
        {
            Console.WriteLine($"Du valgte {myChoise} og dataen valgte {ComputerRandom} du tapte");
            ComputerCount++;
            Console.WriteLine($"Du har {PlayerCount} poeng! og dataen har {ComputerCount} poeng!");
        }
        if (ComputerRandom == "papir")
        {
            Console.WriteLine($"Du valgte {myChoise} og dataen valgte {ComputerRandom} du VANT!");
            PlayerCount++;
            Console.WriteLine($"Du har {PlayerCount} poeng! og dataen har {ComputerCount} poeng!");
        }

        ComputerRandom = ComputerChoise();
        PlayGame(ComputerRandom);
    }  
}

