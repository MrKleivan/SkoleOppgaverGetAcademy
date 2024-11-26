namespace Emne3Oppgaver;

public class Oppgave315
{
    static string[] _board = [" ", "1", "3", "4", "5", "6", "7", "8", "2"];
    public static void Oppgave315F()
    {
        int index = 0;
        CreateBoard();
        void CreateBoard()
        {
            Console.Clear();
            Console.WriteLine($"|{_board[0]}||{_board[1]}||{_board[2]}|");
            Console.WriteLine($"|{_board[3]}||{_board[4]}||{_board[5]}|");
            Console.WriteLine($"|{_board[6]}||{_board[7]}||{_board[8]}|");
        

        

            for (int i = 0; i < _board.Length; i++)
            {
                string number = _board[i];

                if (number == " ")
                {
                    index = i;
                }
            }

            string myChoise = "";
            if(index == 0)
            {
                Console.WriteLine($"Hvor vil du flytte alt1: {_board[1]} eller alt2: {_board[3]}");
                myChoise = Console.ReadLine();
                MakeMove(index.ToString(), myChoise);
            }
            if(index == 1)
            {
                Console.WriteLine($"Hvor vil du flytte alt1: {_board[0]} eller alt2: {_board[2]} eller alt3: {_board[4]}");
                myChoise = Console.ReadLine();
                MakeMove(index.ToString(), myChoise);
            }
            if(index == 2)
            {
                Console.WriteLine($"Hvor vil du flytte alt1: {_board[1]} eller alt12 {_board[5]}");
                myChoise = Console.ReadLine();
                MakeMove(index.ToString(), myChoise);
            }
            
            if(index == 3)
            {
                Console.WriteLine($"Hvor vil du flytte alt1: {_board[0]} eller alt2: {_board[4]} eller alt3: {_board[6]}");
                myChoise = Console.ReadLine();
                MakeMove(index.ToString(), myChoise);
            }
            if(index == 4)
            {
                Console.WriteLine($"Hvor vil du flytte alt1: {_board[3]} eller alt2: {_board[1]} eller alt3: {_board[5]} eller alt4: {_board[7]}");
                myChoise = Console.ReadLine();
                MakeMove(index.ToString(), myChoise);
            }
            if(index == 5)
            {
                Console.WriteLine($"Hvor vil du flytte alt1: {_board[4]} eller alt12 {_board[2]} eller alt3: {_board[8]}");
                myChoise = Console.ReadLine();
                MakeMove(index.ToString(), myChoise);
            }
            
            if(index == 6)
            {
                Console.WriteLine($"Hvor vil du flytte alt1: {_board[3]} eller alt2: {_board[7]}");
                myChoise = Console.ReadLine();
                MakeMove(index.ToString(), myChoise);
            }
            if(index == 7)
            {
                Console.WriteLine($"Hvor vil du flytte alt1: {_board[6]} eller alt2: {_board[4]} eller alt3: {_board[8]}");
                myChoise = Console.ReadLine();
                MakeMove(index.ToString(), myChoise);
            }
            if(index == 8)
            {
                if (_board[0] == "1" && _board[1] == "2" && _board[2] == "3" && _board[3] == "4" && _board[4] == "5" &&
                    _board[5] == "6" && _board[6] == "7" && _board[7] == "8")
                {
                    Console.WriteLine("Gratulerer du har vunnet spillet");
                    Console.WriteLine("Vil du spille igjen? (j/n)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "j") {_board = ["2", " ", "6", "7", "8", "5", "1", "3", "4"]; CreateBoard();}
                    if (answer == "n") {Console.WriteLine("Takk for at du spilte");Environment.Exit(0);}
                }
                else 
                {
                    Console.WriteLine($"Hvor vil du flytte alt1: {_board[7]} eller alt12 {_board[5]}");
                    myChoise = Console.ReadLine();
                    MakeMove(index.ToString(), myChoise);
                }
            }
        }
        void MakeMove(string yourSpot, string otherSpot)
        {
            int newIndex = 0;
            for (int i = 0; i < _board.Length; i++)
            {
                if(_board[i] == otherSpot)
                {
                    newIndex = i;
                    break;
                }
            }
            _board[index] = otherSpot;
            _board[newIndex] = " ";
            
            CreateBoard();
        }
        

    }
    
}