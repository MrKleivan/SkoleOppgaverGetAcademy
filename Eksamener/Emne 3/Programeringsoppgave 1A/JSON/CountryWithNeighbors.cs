using System.Text.Json;

namespace ObligEmne3.JSON;

public partial class CountryWithNeighbors
{
    public string country { get; set; }
    public Neighbor[] neighbors { get; set; }

    public static CountryWithNeighbors[]  GetCountries()
    {
        var json = File.ReadAllText("../../../JSON/countries.json");
        return JsonSerializer.Deserialize<CountryWithNeighbors[]>(json);
    }

    
    public string[] GetNeighbors()
    {
        return neighbors
            .Where(c => c.borderType.Contains("land"))
            .Select(n => n.country)
            .ToArray();
    }
    public partial class Neighbor
    {
        public string country { get; set; }
        public string borderType { get; set; }
    }
    
}