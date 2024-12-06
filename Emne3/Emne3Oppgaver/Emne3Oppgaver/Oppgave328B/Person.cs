using System.Data.Common;

namespace Emne3Oppgaver.Oppgave328B;

public class Person
{
    public int Id {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int BirthYear {get; set;}
    public int DeathYear {get; set;}
    public Person Father {get; set;}
    public Person Mother {get; set;}

    

    public string GetDescription()
    {
        var description = FirstName + " " + LastName + $" (Id={Id})" + $" Født: {BirthYear} Død: {DeathYear} Far: {Father.FirstName} (Id={Father.Id}) Mor: {Mother.FirstName} (Id={Mother.Id})";
        return description;
    }
}