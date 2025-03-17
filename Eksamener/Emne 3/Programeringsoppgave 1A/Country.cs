
namespace ObligEmne3;

public class Country
{
    public string CountryName { get; }
    public List<Country?> Neighburs { get; } = new List<Country?>();

    public Country(string country, string[] neighburs, List<Country> countries)
    {
        CountryName = country;
        if (neighburs.Length > 0)
        {
            Neighburs = AddNeighbour(neighburs, countries);
        }
    }


    private Country(string neighbur)
    {
        CountryName = neighbur;
    }
    
    private List<Country>? AddNeighbour(string[] neighburs, List<Country> countries)
    {
        List<Country> neighbours = new List<Country>();
        foreach (var neighbur in neighburs)
        {
            bool isNeighbourInnList = CheckNeighbour(neighbur, countries);
            if (isNeighbourInnList)
            {
                neighbours.Add(countries.Find(c => c.CountryName == neighbur) ?? throw new InvalidOperationException());
            }
            else
            {
                neighbours.Add(new Country(neighbur));
            }
        }

        return neighbours;
    }
    private bool CheckNeighbour(string neighbur, List<Country> countries)
    {
        foreach (var country in countries)
        {
            if (country.CountryName == neighbur)
            {
                return true;
            }
        }
        return false;
    }
}