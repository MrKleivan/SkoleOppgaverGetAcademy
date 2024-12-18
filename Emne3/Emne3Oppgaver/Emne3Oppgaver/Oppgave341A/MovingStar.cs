namespace Emne3Oppgaver.Oppgave341A;

public class MovingStar : IStar
{
    private int _col;
    private int _row;

    public MovingStar(int col, int row)
    {
        _col = col;
        _row = row;
    }

    public void Show()
    {
        Console.SetCursorPosition(_col, _row);
        var star = '*';
        Console.WriteLine(star);
    }

    public void Update()
    {
        _col = (_col + 1) % Console.WindowWidth;
    }
}