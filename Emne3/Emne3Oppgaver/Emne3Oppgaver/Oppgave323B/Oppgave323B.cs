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
        var bets = betsText.Split(',');
        var matches = new Match[12];
        for (var i = 0; i < 12; i++)
        {
            matches[i] = new Match(bets[i]);
        }

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
            var selectedIndex = matchNo - 1;
            var selectedMatch = matches[selectedIndex];
            selectedMatch.AddGoal(team == "H");
            var correctCount = 0;
            for (var index = 0; index < matches.Length; index++)
            {
                var match = matches[index];
                var theMatchNo = index + 1;
                var isBetCorrect = match.IsBetCorrect();
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                if (isBetCorrect) correctCount++;
                Console.WriteLine($"Kamp {theMatchNo}: {match.GetScore()} - {isBetCorrectText}");
            }

            Console.WriteLine($"Du har {correctCount} rette.");
        }
    }
}