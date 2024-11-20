namespace Emne3Oppgaver;

public class Oppgave315I
{
    static readonly Random Random = new Random();
    public void Run()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        string[] userInput = Console.ReadLine()!.Split(" ");
        
        PasswordGenerator(userInput);
        
    }

    static void PasswordGenerator(string[] args)
    {
        string password = "";
        if (!IsValid(args))
        {
            ShowHelpText();
            return;
        }

        var pattern = args[1];
        if (pattern.Length.ToString() != args[0])
        {
            int expandLength = int.Parse(args[0]) - pattern.Length;
            for (int i = 0; i < expandLength; i++)
            {
                pattern += "l";
            }
        }

        while (pattern.Length >= 1)
        {
            
            if (pattern[pattern.Length - 1] == 'l')
            {
                password += WriteRandomLowerCaseLetter();
            }
        
            if (pattern[pattern.Length - 1] == 'L')
            {
                password += WriteRandomUpperCaseLetter();
            }
        
            if (pattern[pattern.Length - 1] == 'd')
            {
                password += WriteRandomDigit();
            }
        
            if (pattern[pattern.Length - 1] == 's')
            {
                password += WriteRandomSpecialCharacter();
            }
            pattern = pattern.Remove(pattern.Length - 1, 1);
        }

        Console.WriteLine($"Ditt passord: {password}");
    }

    static bool IsValid(string[] args)
    {
        string s = args[0];
        foreach (var c in s)
        {
            if (char.IsDigit(c) == false) return false;
        }
        
        string w = args[1];
        foreach (var c in w)
        {
            if (c == 'l' || c == 'L' || c == 's' || c == 'd') {return true;}
            else {return false;}
        }
        return true;
    }

    static void ShowHelpText()
    {
        Console.WriteLine("PasswordGenerator  \n" +
                          "Options:\n" +
                          "- l = liten bokstav\n" +
                          "- L = stor bokstav\n" +
                          "- d = siffer\n" +
                          "- s = spesialtegn (!\"#\u00a4%&/(){}[]\n" +
                          "Eksempel: PasswordGenerator 14 lLssdd    betyr\n" +
                          "        Min. 1 liten bokstav\n" +
                          "        Min. 1 1 stor bokstav\n" +
                          "        Min. 2 spesialtegn\n" +
                          "        Min. 2 sifre\n" +
                          "        Lengde på passordet skal være 14");
    }

    static string WriteRandomLowerCaseLetter()
    {
        string s = GetRandomLetter('a', 'z').ToString();
        return s;
    }
    static string WriteRandomUpperCaseLetter()
    {
        string s = GetRandomLetter('A', 'Z').ToString();
        return s;
    }
    static string WriteRandomDigit()
    {
        string s = Random.Next(0, 9).ToString();
        return s;
    }
    
    static string WriteRandomSpecialCharacter()
    {
        string specialeLetter = "((!"+ '"' + "#¤%&/(){}[]";
        int index = Random.Next(0, 9);
        return specialeLetter[index].ToString();
    }
    
    static char GetRandomLetter(char min, char max)
    {
        return (char)Random.Next(min, max);
    }
}