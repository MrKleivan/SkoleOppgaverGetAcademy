using ObligEmne3;

var app = new CountriesWithNeighborsByLand();

var countryCodeConsole = new CountryCodeConsole("Velg et land: ");
var countryName = countryCodeConsole.AskForCountry();
Console.Clear();
Console.WriteLine(countryName);
Thread.Sleep(1500);

while (true)
{
    Console.Clear();
    List<Country> CountryList = app.GetListOfCountries();
    var countryQuiz = new GuessNeighborsOfCountryQuiz(CountryList);
    countryQuiz.Run();
    countryQuiz.ShowResult();
}
