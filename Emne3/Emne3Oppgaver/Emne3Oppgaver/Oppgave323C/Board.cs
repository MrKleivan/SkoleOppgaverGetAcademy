namespace Emne3Oppgaver.Oppgave323C;

public class Board
{
    public Square[] Squares {get; private set;}
    private readonly Random _random = new Random();
    public Board()
    {
        Squares = new Square[9];
        for (int i = 0; i < Squares.Length; i++)
        {
            Squares[i] = new Square();
        }
    }

    

    public void MarkRandom(bool mark, Board board)
    {
        while (true)
        {
            var randomNumber = _random.Next(0, 8);
            if (board.Squares[randomNumber].CheckIfSquareIsEmpty())
            {
                board.Squares[randomNumber]._isOwndBy = "o";
                break;
            }
            else
            {
                continue;
            }
        }
    }

    public void Mark(string? position, Board board)
    {
        int index = 0; 
        if (position == "a1")
        {
            index = 0;
        }
        else if (position == "a2")
        {
            index = 1;
        }
        else if (position == "a3")
        {
            index = 2;
        }
        else if (position == "b1")
        {
            index = 3;
        }
        else if (position == "b2")
        {
            index = 4;
        }
        else if (position == "b3")
        {
            index = 5;
        }
        else if (position == "c1")
        {
            index = 6;
        }
        else if (position == "c2")
        {
            index = 7;
        }
        else if (position == "c3")
        {
            index = 8;
        }
        int newIndex = index;
        board.Squares[newIndex]._isOwndBy = board.Squares[newIndex].CheckIfSquareIsEmpty() ? "x" : board.Squares[newIndex]._isOwndBy = board.Squares[newIndex]._isOwndBy;
    }

    public void CheckIfComplite()
    {
        
    }
}