namespace Emne3Oppgaver.Oppgave329C;

public class Oppgave329C
{
    public static void Run()
    {
        var bottles = new Bottle[2];


        while (true)
        {
            var operations = new Operations();
        
            Console.WriteLine("1: Fylle flaske 1 fra springen\n" +
                              "2: Fylle flaske 2 fra springen\n" +
                              "3: Tømme flaske 1 i flaske 2\n" +
                              "4: Tømme flaske 2 i flaske 1\n" +
                              "5: Fylle opp flaske 2 med flaske 1\n" +
                              "6: Fylle opp flaske 1 med flaske 2\n" +
                              "7: Tømme flaske 1 (kaste vannet)\n" +
                              "8: Tømme flaske 2 (kaste vannet)");
            Console.WriteLine("Skriv inn hvor mange liter flaske 1 skal romme:");
            var volumCommandForBottleOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Skriv inn hvor mange liter flaske 2 skal romme:");
            var volumCommandForBottleTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Skriv inn hvor mange antall kombinasjoner som skal utføres:");
            var combinationCommand = Console.ReadLine().ToUpper();
        
            operations.FindSolutionOpperation(bottles);
            Console.WriteLine("Trykk enter for å fortsette eller trykk inn c også enter for å avslutte");
            var command = Console.ReadLine();
        }
        
    }

    
    
}