namespace Emne3Oppgaver.OppgaveMedKodeLerer;

public class OppgaveMedLerer
{
    // Den lille kattepus so søtt på de på gamle, slitterr sofaen kattepus...

    
    public void Run()
    {
        Console.WriteLine("Skriv inn en text du vil analysere");
        string textToAnalyze = Console.ReadLine();
        AnalyzeText analyzeText = new AnalyzeText(textToAnalyze);   
        
        
        
        Console.WriteLine(analyzeText.CleanedText);
        Console.WriteLine("Antall bokstaver:" + analyzeText.AmountOfLetters);
        Console.WriteLine("Antall ord:" + analyzeText.AmountOfWords);
        Console.WriteLine("Antall bokstaver i lengste ord:" + analyzeText.AmountOfLettersInLongestWord);
        Console.WriteLine(analyzeText.LongestWord);
        Console.WriteLine("Antall bokstaver i korteste ord:" + analyzeText.AmountOfLettersInShortestWord);
        Console.WriteLine(analyzeText.ShortestWord);
    }
    
}