namespace Emne3Oppgaver;

public class Oppgave315G
{
    public void Run()
    { 
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    const int range = 250;
    var counts = new int[range];
    var text = "Something";

    CreateLetterCountArray(range, counts, text);

    
    }

    private void CreateLetterCountArray(int range,int[] counts,string? text)
    {
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine()?.ToLower();
            if (text == null) continue;
            foreach (var character in text)
            {
                counts[character]++;
            }

            CreateAmountOfLetterTable(range, counts, text);
        }
        
    }

    private void CreateAmountOfLetterTable(int range, int[] counts,string? text)
    {
        for (var i = 0; i < range; i++)
        {
            if (counts[i] <= 0) continue;
            var character = (char)i;

            if (text != null)
            {
                Console.WriteLine(character + " - " + counts[i] + " - " + (counts[i] * 100 / text.Length) + "%");
            }
        }
        
        Run();
    }
}
