namespace Emne3Oppgaver;

public class Oppgave321A
{
    public void Run()
    {
        
        var counter = new CharCounter();
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            counter.AddText(text);
            counter.ShowCounts();
        }
    }
    
}