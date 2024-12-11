namespace Emne3Oppgaver.Oppgave329B;

public class Oppgave329BTest
{
    
    [Test]
    public void Test1CharCharacter()
    {
        var row = new VirtualScreenRow(10);
        row._cells[2].AddLowerLeftCorner();
        
        var caracter = row._cells[2].GetCharacter();
        var caracter2 = row._cells[1].GetCharacter();
        Assert.That(caracter, Is.EqualTo('\u2514'));
        Assert.That(caracter2, Is.EqualTo(' '));
    }
}