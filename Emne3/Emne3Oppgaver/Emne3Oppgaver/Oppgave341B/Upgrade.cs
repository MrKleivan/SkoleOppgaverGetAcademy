namespace Emne3Oppgaver.Oppgave341B;

public class Upgrade(ClickerGame game) : ICommand
{
    public char Character { get; } = 'K';
    public void Run()
    {
        
        if (game.points >= 10)
        {
            game.pointsPerClick += game.pointsPerClickIncrease;
            game.points -= 10;
        }
        else game.pointsPerClick = game.pointsPerClick;
    }
}