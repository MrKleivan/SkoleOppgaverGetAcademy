namespace Emne3Oppgaver;

public class CharCounter
{
    
    static int range = 250;
    int[] counts = new int[range];
    public void AddText(string? text)
    {
        foreach (var character in text ?? string.Empty)
        {
            counts[(int)character]++;
        }
    }

    public void ShowCounts()
    {
        for (var i = 0; i < range; i++)
        {
            if (counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(character + " - " + counts[i]);
            }
        }
    }
    
}