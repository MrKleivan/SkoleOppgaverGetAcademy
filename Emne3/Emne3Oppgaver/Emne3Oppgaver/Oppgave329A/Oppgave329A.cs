namespace Emne3Oppgaver.Oppgave329A;

public class Oppgave329A
{
    public static void Run()
    {
        var random = new Random();
        var players = new[] { new Player("Per", 10), new Player("Pål", 10), new Player("Espen", 10) };
        for (var round = 1; round <= 10; round++)
        {
            var playerIndex1 = random.Next(players.Length);
            var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;
            var player1 = players[playerIndex1];
            var player2 = players[playerIndex2];
            player1.Play(player2);
        }

        var winner = players[0];
        foreach (var player in players)
        {
            player.ShowNameAndPoints();
            if (player.Points > winner.Points)
            {
                winner = player;
            }
        }
        Console.WriteLine($"Vinner: {winner.Username}!. Med: {winner.Points} Poeng");
    }
}