namespace Emne3Oppgaver.Oppgave323C;

public class Oppgave323C
{
    public void Run()
    {
        var board = new Board();
        var gameConsole = new GameConsole(board);
        
        while (true)
        {
            gameConsole.Show(board);
            Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
            var position = Console.ReadLine();
            board.Mark(position, board);
            // Thread.Sleep(2000);
            board.MarkRandom(false, board);
            
        }
        Console.WriteLine("hei");
    }
}