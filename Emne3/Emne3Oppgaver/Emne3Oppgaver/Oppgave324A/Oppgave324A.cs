namespace Emne3Oppgaver.Oppgave324A;

public class Oppgave324A
{
    public static void Run()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Skriv inn dine 12 tippinger med komma mellom hver (en tipping for hver kamp): ? ");
        var betsText = Console.ReadLine()!.ToUpper();
        
        var coupon = new Coupon(betsText)._coupon;
        // for (var i = 0; i < 12; i++)
        // {
        //     coupon[i] = new Match(bets[i]);
        // }

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
            var selectedMatch = coupon[selectedIndex];
            if (team != null) selectedMatch.AddGoal(team);
            var correctCount = 0;
            for (var index = 0; index < coupon.Length; index++)
            {
                var match = coupon[index];
                var theMatchNo = index + 1;
                var isBetCorrect = match.IsBetCorrect();
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                if (isBetCorrect) correctCount++;
                Console.WriteLine($"Kamp {theMatchNo}: {match.Score} - {isBetCorrectText}");
            }

            Console.WriteLine($"Du har {correctCount} rette.");
        }
    }
}