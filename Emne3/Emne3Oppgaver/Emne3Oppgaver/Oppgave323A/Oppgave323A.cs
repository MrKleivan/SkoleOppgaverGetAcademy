namespace Emne3Oppgaver.Oppgave323A;

public class Oppgave323A
{
    public void Run()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Hva har du tippet for denne kampen? ");
        var bet = Console.ReadLine();
        
        bool matchIsRunning = true;

        if (bet != null)
        {
            while (matchIsRunning)
            {
                Console.Write("Kommandoer: \n" + 
                              " - H = scoring hjemmelag\n" + 
                              " - B = scoring bortelag\n" + 
                              " - X = kampen er ferdig\n" + 
                              "Angi kommando: ");
                var command = Console.ReadLine();
                matchIsRunning = command != "X";
                if (command != null) Match.CreateGameGoals(bet, command);
                Console.WriteLine($"Stillingen er {Match.HomeGoals}-{Match.AwayGoals}.");
            }
            var isBetCorrectText = Match.ShowResult(bet);
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }

   
}