namespace Emne3Oppgaver.OppgaveMedKodeLerer;

public class AnalyzeText
{
    public string? Text { get; private set; }
    public string CleanedText { get; private set; }
    public string[] SplitText { get; private set; }
    public int AmountOfLetters { get; private set; }
    public int AmountOfWords { get; private set; }
    public int AmountOfLettersInLongestWord { get; private set; }
    public string LongestWord { get; private set; }
    public int AmountOfLettersInShortestWord { get; private set; }
    public string ShortestWord { get; private set; }

    public AnalyzeText(string? text)
    {
        Text = text;
        CleanedText = CleanText();
        SplitText = SplitTextToArray();
        AmountOfLetters = GetAmountOfLetters();
        AmountOfWords = GetAmountOfWords();
        AmountOfLettersInLongestWord = GetAmountOfLettersInLongestWord();
        LongestWord = GetLongestWord();
        AmountOfLettersInShortestWord = GetAmountOfLettersInShortestWord();
        ShortestWord = GetShortestWord();
    }
    
    string CleanText()
    {
        string cleanedText = "";
        for (int i = 0; i < Text?.Length; i++)
        {
            if (char.IsLetter(Text[i]) || Text[i] == ' ')
            {
                cleanedText += Text[i];
            }
        }
        return cleanedText;
    }

    string[] SplitTextToArray()
    {
        return CleanedText.Split(' ');
    }

    int GetAmountOfLetters()
    {
        var amount = 0;
        for (int i = 0; i < CleanedText.Length; i++)
        {
            if (CleanedText[i] != ' '){
                amount++;
            }
        }
        return amount;
    }

    int GetAmountOfWords()
    {
        var amount = 0;
        for (var index = 0; index < SplitText.Length; index++)
        {
            amount++;
        }

        return amount;
    }

    int GetAmountOfLettersInLongestWord()
    {
        int longestWordLength = 0;
        foreach (var word in SplitText)
        {
            if (longestWordLength < word.Length)
            {
                longestWordLength = word.Length;
            }
        }
        return longestWordLength;        
    }

    string GetLongestWord()
    {
        string longestWords = "";
        string longestWord = "";
        for (var i = 0; i < SplitText.Length; i++)
        {
            var word = SplitText[i];
            if (longestWord.Length < word.Length)
            {
                longestWord = word;
            }
        }

        for (var i = 0; i < SplitText.Length; i++)
        {
            var word = SplitText[i];
            if (longestWord.Length == word.Length)
            {
                longestWords += word + " ";
            }
        }

        return longestWords;
    }
    
    int GetAmountOfLettersInShortestWord()
    {
        string shortestWord = GetLongestWord();

        foreach (var word in SplitText)
        {
            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }
        }
        return shortestWord.Length;
    }

    string GetShortestWord()
    {
        string shortestWord = GetLongestWord();
        var shortestWords = "";
        foreach (var word in SplitText)
        {
            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }
        }
        for (var i = 0; i < SplitText.Length; i++)
        {
            var word = SplitText[i];
            if (shortestWord.Length == word.Length)
            {
                shortestWords += word + " ";
            }
        }
        return shortestWords;
    }
}