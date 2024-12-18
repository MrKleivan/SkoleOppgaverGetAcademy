namespace Emne3Oppgaver.Oppgave341B;

public class SuperUpgrade(ClickerGame game) : ICommand
{
    public char Character { get; } = 'S';
    public void Run()
    {
        if (game.points > 100)
        {
            game.points -= 100;
            game.pointsPerClickIncrease++;
        }
    }
}