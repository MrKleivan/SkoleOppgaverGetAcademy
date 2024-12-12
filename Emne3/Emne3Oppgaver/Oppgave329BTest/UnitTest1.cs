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
        Assert.That(caracter, Is.EqualTo('\u2514')); //  └
        Assert.That(caracter2, Is.EqualTo(' '));
    }
    
    [Test]
    public void Test2CharCharacter()
    {
        var row = new VirtualScreenRow(10);
        row._cells[2].AddHorizontal();
        row._cells[2].AddVertical();
        
        var caracter = row._cells[2].GetCharacter();
        Assert.That(caracter, Is.EqualTo('\u253c')); //  ┼
    }
    
    [Test]
    public void Test3CharCharacters()
    {
        var row1 = new VirtualScreenRow(20);
        var row2 = new VirtualScreenRow(20);
        var row3 = new VirtualScreenRow(20);
        row1.AddBoxTopRow(5, 3);
        row2.AddBoxMiddleRow(4, 5);
        row3.AddBoxBottomRow(3, 7);
        row1.Show();
        row2.Show();
        row3.Show();

        string row1Test = null;
        string row2Test = null;
        string row3Test = null;
        for (var index = 0; index < row1._cells.Length; index++)
        {
            row1Test += row1._cells[index].GetCharacter().ToString();
            row2Test += row2._cells[index].GetCharacter().ToString();
            row3Test += row3._cells[index].GetCharacter().ToString();
        }

        Assert.That( row1Test, Is.EqualTo("     \u250c\u2500\u2510             "));                         //     ┌─┐    
        Assert.That( row2Test, Is.EqualTo("    \u2502   \u2502            "));                              //    │   │
        Assert.That( row3Test, Is.EqualTo("   \u2514\u2500\u2500\u2500\u2500\u2500\u2518           "));     //   └─────┘
    }
}