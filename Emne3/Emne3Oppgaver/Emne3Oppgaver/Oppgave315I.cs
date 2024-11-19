namespace Emne3Oppgaver;

public class Oppgave315I
{
    public void Run()
    {
        string[] userInput = Console.ReadLine().Split(" ");
        
        PasswordGenerator(userInput);
        // PasswordGenerator  
        // Options:
        // - l = liten bokstav
        //     - L = stor bokstav
        //     - d = siffer
        //     - s = spesialtegn (!"#¤%&/(){}[]
        // Eksempel: PasswordGenerator 14 lLssdd
        //     betyr
        // Min. 1 liten bokstav
        // Min. 1 1 stor bokstav
        // Min. 2 spesialtegn
        // Min. 2 sifre
        //     Lengde på passordet skal være 14
    }

    private void PasswordGenerator(string[] args)
    {
        if (!IsValid(args))
        {
            ShowHelpText();
            return;
        }

       Console.WriteLine(args[0] + args[1]);
    }

    private bool IsValid(string[] args)
    {
        foreach (var c in args[1])
        {
            char.IsDigit(c);
        }
        return true;
    }

    private static void ShowHelpText()
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
}