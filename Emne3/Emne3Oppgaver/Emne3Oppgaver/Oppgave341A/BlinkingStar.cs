namespace Emne3Oppgaver.Oppgave341A;

public class BlinkingStar : IStar
{
    private int _phase;
    private int _col;
    private int _row;

    public BlinkingStar(int col, int row)
    {
        _row = row;
        _col = col;
        _phase = 0;
    }

    public void Show()
    {
        Console.SetCursorPosition(_col, _row);
        char start = _phase == 0 ? '*' : ' ';
        Console.Write(start);
    }

    public void Update()
    {
        _phase = _phase == 0 ? 1 : 0;
    }
}