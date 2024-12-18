namespace Emne3Oppgaver.Oppgave341B;

public class CommandSet
{
    
    private ICommand[] commands;
    public CommandSet(ClickerGame game)
    {
        commands = new ICommand[]
        {
            new ExitCommand(),
            new AddPoints(game),
            new Upgrade(game),
            new SuperUpgrade(game)
        };
    }
    public void RunCommand(char charCommand)
    {
        foreach (var command in commands)
        {
            if (command.Character == charCommand)
            {
                command.Run();
            }
        }
    }
}