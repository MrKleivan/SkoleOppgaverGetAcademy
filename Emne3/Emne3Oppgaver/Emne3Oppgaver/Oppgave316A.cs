namespace Emne3Oppgaver;

public class Oppgave316A
{
    public void Run()
    {
        var wordList = CreateWordList();

        var firstWordsList = CreateListOfFirstWords(wordList);
        var secondWordsList = CreateListOfSecondWords(wordList, firstWordsList);

        for (int i = 0; i < firstWordsList.Length; i++)
        {
            Console.WriteLine($"{firstWordsList[i]}" + "____" + $"{secondWordsList[i]}" + "---" + $"{firstWordsList[i].Substring(firstWordsList[i].Length - 3)}" + $"{secondWordsList[i].Substring(0, 3)}");
        }
        Console.WriteLine($"{firstWordsList.Length}");
    }

    private static string[] CreateWordList()
    {
        string[] wordList = File.ReadAllText("ordliste.txt").Split('\t');
        
        var list = new List<string>();
        
        foreach (string word in wordList)
        {
            var isWord = true;
            foreach (char letter in word)
            {
                if (char.IsDigit(letter) || letter == ' ' || letter == '\t' || letter == '\n' || letter == '\r' || letter == '-')
                {
                    isWord = false;
                }
            }
            if (word.Length is > 5 and < 11)
            {
                if (isWord == false) {continue;}
                
                list.Add(word);
            }
        }
        
        return list.ToArray();
    }

    private static bool isValidWord(string wordToValidate, string[] wordList)
    {
        foreach (var word in wordList)
        {
            if (wordToValidate.Substring(wordToValidate.Length - 3) == word.Substring(0, 3))
            {
                return true;
            }
            else {continue;}
        }
        return false;
    }

    private static string[] CreateListOfFirstWords(string[] wordList)
    {
        var Random = new Random();
        int count = 0;
        var list = new List<string>();
        while (count < 200)
        {
            var index = Random.Next(0, wordList.Length);
            string word = wordList[index];
            
            if (!isValidWord(word, wordList)) {continue;}
            else
            {
                wordList[index].Split();
                list.Add(word);
                count++;
            }
        }
        
        return list.ToArray();
    }

    private static string[] CreateListOfSecondWords(string[] wordList, string[] firstWordsList)
    {
        var list = new List<string>();
        foreach (var firstWord in firstWordsList)
        {
            foreach (var secondWord in wordList)
            {
                if (firstWord.Substring(firstWord.Length - 3) == secondWord.Substring(0, 3))
                {
                    list.Add(secondWord);
                    break;
                }
            }
        }
        
        return list.ToArray();
    }
}