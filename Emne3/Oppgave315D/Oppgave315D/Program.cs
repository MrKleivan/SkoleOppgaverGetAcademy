string word = "Skriv et program som leser inn en linje tekst og teller antall ord, finner det lengste ordet, ordet med flest vokaler og ev. annen statistikk du har lyst til å lage.";


static string IsLetter(string c)
{
    c = c.Replace(".","");
    c = c.Replace(",","");
    c = c.ToLowerInvariant();
    
    return c;
}    
string[] words = IsLetter(word).Split(' ');

string longestWord = FindLongestWord(words);
string findWordWithMostVocals = FindWordWithMostVocals(words);

static string FindLongestWord(string[] words)
{
    int wordLength = 0;
    int wordCount = 0;
    
    for (int i = 0; i < words.Length; i++)
    {

        if (wordLength < words[i].Length)
        {
            wordLength = words[i].Length;
            wordCount = i;
        }
        
    }
    string word = words[wordCount];
    return word;
}

static string FindWordWithMostVocals(string[] words)
{
    int vocalTotal = 0;
    int wordCount = 0;
    
    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];
        int vocalsCount = 0;
        for (int j = 0; j < word.Length; j++)
        {
            
            string c = word[j].ToString();
            if (c == "a" || c == "e" || c == "i" || c == "o" || c == "o" || c == "u" || c == "y" || c == "æ" ||
                c == "ø" || c == "å")
            {
                vocalsCount++;

                if (vocalsCount > vocalTotal)
                {
                    vocalTotal = vocalsCount;
                    wordCount = i;
                }
                
            }
        }
        
    }
    string myWord = words[wordCount];
    return myWord;
}

Console.WriteLine($"Lengste ordet i listen er: {longestWord}");
Console.WriteLine($"Ordet i listen med flest vokaler er: {findWordWithMostVocals}");
    