Console.WriteLine("Hello, World!");

Console.WriteLine("Skriv inn et navn");
string InputName = Console.ReadLine();

Console.WriteLine(ReverseName(InputName));
static string ReverseName(string InputName)
{
    string ReverstName = "";
    
    for (int i = InputName.Length - 1; i >= 0; i--)
    {
        var Letter = InputName[i];
        ReverstName += Letter;
    }

    return ReverstName;
}


