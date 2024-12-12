namespace Emne3Oppgaver.Oppgave329B;

public class VirtualScreen
{
    private VirtualScreenRow[] _rows;

    public VirtualScreen(int width, int height)
    {
        _rows = new VirtualScreenRow[height + 1];
        for (int i = 0; i < height + 1; i++)
        {
            _rows[i] = new VirtualScreenRow(width);
        }
    }

    public void Add(Box box)
    {
        _rows[box.StartY].AddBoxTopRow(box.X, box.Width);
        for (int i = box.StartY + 1; i < box.EndY; i++)
        {
            _rows[i].AddBoxMiddleRow(box.X, box.Width);
        }
        _rows[box.EndY].AddBoxBottomRow(box.X, box.Width);
    }

    public void Show()
    {
        for (var index = 0; index < _rows.Length; index++)
        {
            for (int i = 0; i < _rows[index]._cells.Length; i++)
            {
                Console.Write(_rows[index]._cells[i].GetCharacter());
            }
            Console.WriteLine();
        }
    }
}