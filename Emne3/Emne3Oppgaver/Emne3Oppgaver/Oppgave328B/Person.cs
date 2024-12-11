using System.Data.Common;

namespace Emne3Oppgaver.Oppgave328B;

public class Person
{
    

    public int Id {get; set;}
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get; set;} = string.Empty;
    public int BirthYear {get; set;}
    public int DeathYear {get; set;}
    public Person? Father {get; set;}
    public Person? Mother {get; set;}


    public string GetDescription()
    {
        var description = FirstName + (LastName != string.Empty ? $" {LastName} (Id={Id})" : $" (Id={Id})");

        if (BirthYear > 0)
        {
            description += $" Født: {BirthYear}";
        }

        if (DeathYear > 0)
        {
            description += $" Død: {DeathYear}";
        }
        
        if (Father != null)
        {
            description += $" Far: {Father.FirstName} (Id={Father.Id})";
        }
        if (Mother != null)
        {
            description += $" Mor: {Mother.FirstName} (Id={Mother.Id})";
        }
        return description.Trim();
    }

    
}