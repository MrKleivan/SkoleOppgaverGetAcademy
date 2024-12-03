
namespace Emne3Oppgaver.Oppgave323B1;

public class Oppgave323B1
{
    public void Run()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Skriv inn dine 12 tippinger med komma mellom hver (en tipping for hver kamp): ? ");
        
        var betsText = Console.ReadLine();

        var matches = betsText != null ?  new TwelveMatches(betsText) : null;

        while (true)
        {
            Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
            var command = Console.ReadLine();
            if (command == "X") break;
            var matchNo = Convert.ToInt32(command);
            Console.Write("Kommandoer: \n" + 
                          " - H = scoring hjemmelag\n" + 
                          " - B = scoring bortelag\n" + 
                          " - X = kampen er ferdig\n" + 
                          "Angi kommando: ");
            var team = Console.ReadLine();
            matches?.CreateCoupon(team, matchNo, matches);
            

            if (matches != null) Console.WriteLine($"Du har {matches.Count} rette.");
        }
    }
    // B,B,H,H,U,H,B,H,H,B,U,H
}