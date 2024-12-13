namespace Emne3Oppgaver.OppgaveMedKodeLerer;

public class OppgaveMedLerer
{
    private string text = "Den lille kattepus sov søtt på den gamle, slitte sofaen...";

    
    public void Run()
    {
        var tempText = CleanText(text);
        string[] newText = tempText.Split(" ");

        int count = 0;
        int wordCount = 0;
        string longestWord = "";
        int longestWordLength = 0;
        foreach (var word in newText)
        {
            wordCount++;
            for (int i = 0; i < word.Length; i++)
            {
                count++;
                if (longestWordLength < word.Length)
                {
                    longestWordLength = word.Length;
                    longestWord = word;
                }
            }
        }
        
        Console.WriteLine(wordCount + " " + count);
        Console.WriteLine(longestWord + " " + longestWordLength);
        
    }

    public string CleanText(string text)
    {
        string tempText = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]) || text[i] == ' ')
            {
                tempText += text[i];
            }
        }

        return tempText;
    }
    
}