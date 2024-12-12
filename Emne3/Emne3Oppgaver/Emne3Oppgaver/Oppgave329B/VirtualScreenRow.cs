namespace Emne3Oppgaver.Oppgave329B;

public class VirtualScreenRow
{
    public VirtualScreenCell[] _cells { get; private set; }

    public VirtualScreenRow(int screenWidth)
    {
        _cells = new VirtualScreenCell[screenWidth + 1];
        for (int i = 0; i < screenWidth + 1; i++)
        {
            _cells[i] = new VirtualScreenCell();
        }
    }

    public void AddBoxTopRow(int boxX, int boxWidth)
    {
        _cells[boxX].AddUpperLeftCorner();
        for (int i = boxX + 1; i < boxX + boxWidth - 1; i++)
        {
            _cells[i].AddHorizontal();
        }
        _cells[boxX + boxWidth - 1].AddUpperRightCorner();
    }

    public void AddBoxMiddleRow(int boxX, int boxWidth)
    {
        _cells[boxX].AddVertical();
        _cells[boxX + boxWidth - 1].AddVertical();
    }
    public void AddBoxBottomRow(int boxX, int boxWidth)
    {
        _cells[boxX].AddLowerLeftCorner();
        for (int i = boxX + 1; i < boxX + boxWidth - 1; i++)
        {
            _cells[i].AddHorizontal();
        }
        _cells[boxX + boxWidth - 1].AddLowerRightCorner();
    }


    public void Show()
    {
        string boxes = null;
        for (int i = 0; i < _cells.Length; i++)
        {
            boxes += _cells[i].GetCharacter();
        }
        Console.WriteLine(boxes);
    }
}