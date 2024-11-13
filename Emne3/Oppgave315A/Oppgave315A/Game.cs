namespace Oppgave315A;

public class GameNumber
{
    public static int GetRandomNumber()
    {
        var random = new Random();
        var number = random.Next(1,10);
        return number;
    }
}