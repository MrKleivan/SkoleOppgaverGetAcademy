using ObligEmne3.JSON;

namespace ObligEmne3;

public class CountriesWithNeighborsByLand
{
    
    private List<Country> Countries { get; set; } = new ();

    public CountriesWithNeighborsByLand()
    {
        foreach (var country in CountryWithNeighbors.GetCountries())
        {
            AddCountry(country.country, country.GetNeighbors());
        }
    }
    public List<Country> GetListOfCountries()
    {
        return Countries;
    }

    public void AddCountry(string countryName, string[] neighboringCountryNames)
    {
        bool isNewCountry = ChechIfNewCountry(countryName);
        
        if (isNewCountry)
        {
            Countries.Add(new Country(countryName, neighboringCountryNames, Countries));
        }
    }

    

    private bool ChechIfNewCountry(string countryName)
    {
        foreach (Country country in Countries)
        {
            if (country.CountryName == countryName)
            {
                return false;
            }
        }
        return true;
    }
}