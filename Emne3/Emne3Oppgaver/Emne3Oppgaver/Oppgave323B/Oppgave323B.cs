namespace Emne3Oppgaver.Oppgave323B;

public class Oppgave323B
{
    public void Run()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Skriv inn dine 12 tippinger med komma mellom hver (en tipping for hver kamp): ? ");
        var betsText = Console.ReadLine();
        var matches = Match.CreateCoupon(betsText);

        while (true)
        {
            Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
            var command = Console.ReadLine();
            if (command == "X") break;
            var matchNo = Convert.ToInt32(command);
            while (true)
            {
                Console.Clear();
                Console.Write("Kommandoer: \n" + 
                              " - H = scoring hjemmelag\n" + 
                              " - B = scoring bortelag\n" + 
                              " - X = kampen er ferdig\n" + 
                              "Angi kommando: ");
                string team = Console.ReadLine()!.ToUpper();
                var selectedIndex = matchNo - 1;
                var selectedMatch = matches[selectedIndex];
                selectedMatch.AddGoal(team);
                if (team == "X") break;
            }
            var correctCount = 0;
            Match.ShowPlayedMatches(matches, correctCount);

            Console.WriteLine($"Du har {correctCount} rette.");
        }
        
    }
    // B,B,H,H,U,H,B,H,H,B,U,H   
}