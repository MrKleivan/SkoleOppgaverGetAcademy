namespace Emne3Oppgaver.Oppgave324A;

public class Oppgave324A
{
    public static void Run()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" + 
                      " - halvgardering: HU, HB, UB\n" + 
                      " - helgardering: HUB\n" + 
                      "Skriv inn dine tippinger med komma mellom hver (en tipping for hver kamp): ? ");
        var betsText = Console.ReadLine()!.ToUpper();
        var bets = betsText.Split(",");
        var coupon = new Coupon(bets);
        // for (var i = 0; i < 12; i++)
        // {
        //     coupon[i] = new Match(bets[i]);
        // }

        while (true)
        {
            Console.Write($"Skriv kampnr. 1-{bets.Length} for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
            var command = Console.ReadLine();
            if (command == "X") break;
            var matchNo = Convert.ToInt32(command);
            Console.Write("Kommandoer: \n" + 
                          " - H = scoring hjemmelag\n" + 
                          " - B = scoring bortelag\n" + 
                          " - X = kampen er ferdig\n" + 
                          "Angi kommando: ");
            var team = Console.ReadLine();
            if (team != null) coupon.ShowCoupon(team, matchNo);
            
        }
    }
}