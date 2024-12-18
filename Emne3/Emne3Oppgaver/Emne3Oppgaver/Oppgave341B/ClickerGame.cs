namespace Emne3Oppgaver.Oppgave341B;

public class ClickerGame
{
    public int points { get; set; } = 0;
    public int pointsPerClick { get; set; } = 1;
    public int pointsPerClickIncrease { get; set; } = 1;

    public void Run()
    {
        // var game = new ClickerGame();
        var commands = new CommandSet(this);
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n"
                              + " - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       " 
                              + "koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       "
                              + "øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       "
                              + "koster 100 poeng\r\n - X = avslutt applikasjonen");
            Console.WriteLine($"Du har {this.points} poeng.");
            Console.WriteLine("Trykk tast for ønsket kommando.");
            var command = Console.ReadKey().KeyChar;
            commands.RunCommand(command);
            
        }
    }
    
}