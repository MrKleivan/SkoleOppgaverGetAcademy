namespace Emne3Oppgaver.Oppgave328B;

public class FamilyApp()
{
    public string WelcomeMessage;
    public string CommandPrompt;
    public List<Person> _people;
    public FamilyApp(params Person[] people) : this()
    {
        _people = new List<Person>(people);
        WelcomeMessage = "welcomeMessage";
        CommandPrompt = "commandPrompt";
    }

    public string HandleCommand(string? command)
    {
        string outputText = "";
        string[]? commands = command?.Split(" ");
        if ((commands?[0] == "hjelp") && (commands[0] == "help") && (commands[0] == "vis"))
        {
            throw new InvalidOperationException("Feil input");
        }

        if (commands?[0] == "hjelp")
        {
            outputText = "hjelp";
        }
        else if (commands?[0] == "liste")
        {
            outputText = "list";
        }
        else if (commands?[0] == "vis")
        {
            var childText = "";
            outputText = $"{_people[int.Parse(commands[1]) - 1].GetDescription()}\n";
            foreach (var person in _people)
            {
                if (person.Father == _people[int.Parse(commands[1]) - 1])
                {
                    childText = "  Barn:\n";
                    outputText += childText;
                    break;
                }
            }
            foreach (var person in _people)
            {
                if (person.Father == _people[int.Parse(commands[1]) - 1])
                {
                    outputText += $"    {person.FirstName} (Id={person.Id}) Født: {person.BirthYear}\n";
                }
            }
        }

        return outputText;
    }
}
