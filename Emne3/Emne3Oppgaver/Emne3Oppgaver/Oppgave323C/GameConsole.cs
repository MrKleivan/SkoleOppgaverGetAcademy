namespace Emne3Oppgaver.Oppgave323C;

public class GameConsole(Board board)
{
   public void Show(Board board)
   { 
       Console.Clear();
       Console.Write("  a b c \n"
       + " "+"┌─────┐ \n" 
       + "1"+$"│{board.Squares[0]._isOwndBy} {board.Squares[1]._isOwndBy} {board.Squares[2]._isOwndBy}│ \n" 
       + "2"+$"│{board.Squares[3]._isOwndBy} {board.Squares[4]._isOwndBy} {board.Squares[5]._isOwndBy}│ \n" 
       + "3"+$"│{board.Squares[6]._isOwndBy} {board.Squares[7]._isOwndBy} {board.Squares[8]._isOwndBy}│ \n" 
       + " "+"└─────┘");
   }
   
   
}