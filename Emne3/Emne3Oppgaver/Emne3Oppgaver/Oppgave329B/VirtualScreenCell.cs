namespace Emne3Oppgaver.Oppgave329B;

public class VirtualScreenCell
{
    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }
    // public char Character{ get; private set; }

    // public VirtualScreenCell()
    // {
    //     Character = GetCharacter();
    // }
    
    public char GetCharacter()
    {
        // ┌ ─ ┐ └ ┘ │  ┬ ┤ ├ ┴ ┬
        char letter = Up && Down && !Left && !Right ? '\u2502' //  │
                        : Up && !Down && Left && !Right ? '\u2518' //  ┘
                        : Up && !Down && !Left && Right ? '\u2514' //  └
                        : Up && Down && Left && !Right ? '\u2524' //   ┤
                        : Up && Down && !Left && Right ? '\u251c' //   ├
                        : !Up && Down && Left && !Right ? '\u2510' //  ┐
                        : !Up && Down && !Left && Right ? '\u250c' //  ┌
                        : !Up && !Down && Left && Right ? '\u2500' //  ─
                        : Up && Down && Left && Right ? '\u253c'  //   ┼
                        : Up && !Down && Left && Right ? '\u2534' //   ┴
                        : !Up && Down && Left && Right ? '\u252c' //   ┬
                        :  ' ';
        
        return letter;
    }

    public void AddHorizontal()
    {
        Left = true;
        Right = true;
    }

    public void AddVertical()
    {
        Up = true;
        Down = true;
    }

    public void AddLowerLeftCorner()
    {
        Right = true;
        Up = true;
    }

    public void AddLowerRightCorner()
    {
        Left = true;
        Up = true;
    }
    public void AddUpperLeftCorner()
    {
        Right = true;
        Down = true;
    }

    public void AddUpperRightCorner()
    {
        Left = true;
        Down = true;
    }

}