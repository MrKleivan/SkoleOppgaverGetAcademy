namespace Emne3Oppgaver.Oppgave341B;

public class AddPoints(ClickerGame game) : ICommand
{
    public char Character { get; } = ' ';
    public void Run()
    {
        game.points += game.pointsPerClick;
    }
}