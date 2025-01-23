namespace ObligEmne3;

public class GuessNeighborsOfCountryQuiz
{
    private string CountryName { get; set; }
    private List<string> CountryNeighbors { get; set; }
    private List<string> GuestNeighbors { get; set; }
    private List<string> Guesses { get; set; }
    private List<string> NeighboursNotGuest { get; set; }
    
    public GuessNeighborsOfCountryQuiz(List<Country> countryList)
    {
        CountryName = GetRandomCountry(countryList);
        CountryNeighbors = AskForNeighborsOfRandomCountry(CountryName, countryList);
        GuestNeighbors = new List<string>();
        Guesses = new List<string>();
        NeighboursNotGuest = CountryNeighbors;
    }

    private string GetRandomCountry(List<Country> countryList)
    {
        Random random = new Random();
        var listOfCountries = countryList.Where(c => c.Neighburs?.Count >= 1).ToList();
        var randomCountry = listOfCountries[random.Next(0, listOfCountries.Count - 1)].CountryName;
        return randomCountry;
    }

    private List<string> AskForNeighborsOfRandomCountry(string countryName, List<Country> countryList)
    {
        var naighbours = new List<string>();
        Country? country = countryList.Find(country => country.CountryName == countryName);
        foreach (Country? neighbur in country.Neighburs)
        {
            naighbours.Add(neighbur.CountryName);
        }
        
        return naighbours;
    }

    public void Run()
    {
        var wrongGuessesCount = 0;
        var guessCount = 0;
        var guestCountries = "";
        bool isCorrectAnswer = false;

        while (guessCount < CountryNeighbors.Count)
        {
            if (wrongGuessesCount >= 5)
            {
                Console.WriteLine("Vil du fortsette? Tast enter vis du vil fortsette eller tast n og enter om du vil avslutte.");
                var command = Console.ReadLine();
                if (command == "n")
                {
                    break;
                }
            }
            var answerText = $"{(isCorrectAnswer ? "riktig" : "Feil")}";
            Console.Clear();
            Console.WriteLine("Quiz: Gjett navnene på nabolandene til et tilfeldig land hvor landene grenser via land");
            Console.WriteLine($"{guestCountries}");
            Console.WriteLine(guessCount == 0 ? "" : answerText);
            Console.WriteLine($"Hvilke land grenser til: {CountryName}.\n"
                              + "Skriv inn navnet på et naboland og trykk enter eller skriv inn: exit og trykk enter");
            var guess = Console.ReadLine();
            if (guess == "exit") break;

            isCorrectAnswer = CheckIfAnswerIsCorrect(guess);
            if (isCorrectAnswer)
            {
                NeighboursNotGuest = NeighboursNotGuest.Where(n => n.ToUpper() != guess.ToUpper()).ToList();
                GuestNeighbors.Add(guess);
                guestCountries += $"{guess}, ";
            }
            if (!isCorrectAnswer)
            {
                wrongGuessesCount++;
            }
            Guesses.Add($"{guess} - {(isCorrectAnswer ? "Riktig" : "Feil")}");
            guessCount++;
            
        }
    }
    
    public bool CheckIfAnswerIsCorrect(string guess)
    {
        foreach (var neighbour in CountryNeighbors)
        {
            if (neighbour?.ToUpper() == guess.ToUpper())
            {
                return true;
            }
        }
        return false;
    }

    public void ShowResult()
    {
        int count = 0;
        var notGuestNabour = "";
        var neigghbours = "";
        var guesses = "";
        foreach (var neighbour in CountryNeighbors)
        {
            neigghbours += $"{neighbour}, ";
        }
        foreach (var neighbour in NeighboursNotGuest)
        {
            notGuestNabour += $"{neighbour}, ";
            count++;
        }
        foreach (var guess in Guesses)
        {
            guesses += $"{guess}\n";
        }
        Console.Clear();
        Console.WriteLine($"Land: {CountryName}\nNaboland: {neigghbours}");
        Console.WriteLine($"Dine gjettninger:");
        Console.WriteLine(guesses);
        Console.WriteLine($"Du hadde {GuestNeighbors.Count} rette av {CountryNeighbors.Count}");
        if (notGuestNabour.Length > 0)
        {
            Console.WriteLine($"Naboland du ikke gjettet: {notGuestNabour}");
        }
        Console.WriteLine("****************************************************************");
        Console.WriteLine("For å spille på nytt trykk enter, for å avslutte tast c og enter");
        var command = Console.ReadLine();
        if (command == "c")
        {
            Environment.Exit(0);
        }
    }
}
