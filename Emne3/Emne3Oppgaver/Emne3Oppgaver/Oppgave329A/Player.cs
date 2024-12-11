namespace Emne3Oppgaver.Oppgave329A;

public class Player
{
    public string Username { get; set; }
    public int Points { get; set; }
    
    public Player(string username, int points)
    {
        Username = username;
        Points = points;
    }

    public void ShowNameAndPoints()
    {
        Console.WriteLine($"Bruker: {Username}, Poeng: {Points}");
        Console.WriteLine("****************************");
    }

    public void Play(Player player2)
    {
        var random = new Random().Next(1,2);
        if (random == 1)
        {
            player2.Points -= 1;
            Points += 1;
        }
        else
        {
            player2.Points += 1;
            Points -= 1;
        }
    }
}