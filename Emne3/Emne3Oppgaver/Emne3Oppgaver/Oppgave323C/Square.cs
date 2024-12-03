namespace Emne3Oppgaver.Oppgave323C;

public class Square
{
    public string _isOwndBy = " ";
    
    
    public bool CheckIfSquareIsEmpty()
    {
        if(_isOwndBy != " ") return false;
        return true;
    }

    
}