namespace Emne3Oppgaver;

public class Oppgave315F
{
    private string[] _board = [" ", "1", "3", "4", "5", "6", "7", "8", "2"];

    public void Run()
    {

        DrawBoard();
    }

    void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine($"|{_board[0]}||{_board[1]}||{_board[2]}|");
        Console.WriteLine($"|{_board[3]}||{_board[4]}||{_board[5]}|");
        Console.WriteLine($"|{_board[6]}||{_board[7]}||{_board[8]}|");

        var indexOfEmtySquerl = GetIndexOfEmtySquere();


        CreateMoves(indexOfEmtySquerl);

    }

    void CreateMoves(int indexOfEmptySquare)
    {
        
        if(indexOfEmptySquare == 0)
        {
            Console.WriteLine($"Hvor vil du flytte alt1: {_board[1]} eller alt2: {_board[3]}");
            var myChoise = Console.ReadLine();
            if (myChoise == _board[1] || myChoise == _board[3])
            {
                int indexOfUserMove = GetIndexOfUserInput(myChoise);
                MakeMove(indexOfEmptySquare, indexOfUserMove);
            }
            else
            {
                DrawBoard();
            }
        }

        if(indexOfEmptySquare == 1)
        {
            Console.WriteLine($"Hvor vil du flytte alt1: {_board[0]} eller alt2: {_board[2]} eller alt3: {_board[4]}");
            var myChoise = Console.ReadLine();
            if (myChoise == _board[0] || myChoise == _board[2] || myChoise == _board[4])
            {
                int indexOfUserMove = GetIndexOfUserInput(myChoise);
                MakeMove(indexOfEmptySquare, indexOfUserMove);
            }
            else
            {
                DrawBoard();
            }
        }

        if(indexOfEmptySquare == 2)
        {
            Console.WriteLine($"Hvor vil du flytte alt1: {_board[1]} eller alt12 {_board[5]}");
            var myChoise = Console.ReadLine();
            if (myChoise == _board[1] || myChoise == _board[5])
            {
                int indexOfUserMove = GetIndexOfUserInput(myChoise);
                MakeMove(indexOfEmptySquare, indexOfUserMove);
            }
            else
            {
                DrawBoard();
            }
        }

        if(indexOfEmptySquare == 3)
        {
            Console.WriteLine($"Hvor vil du flytte alt1: {_board[0]} eller alt2: {_board[4]} eller alt3: {_board[6]}");
            var myChoise = Console.ReadLine();
            if (myChoise == _board[0] || myChoise == _board[4] || myChoise == _board[6])
            {
                int indexOfUserMove = GetIndexOfUserInput(myChoise);
                MakeMove(indexOfEmptySquare, indexOfUserMove);
            }
            else
            {
                DrawBoard();
            }
        }

        if(indexOfEmptySquare == 4)
        {
            Console.WriteLine($"Hvor vil du flytte alt1: {_board[3]} eller alt2: {_board[1]} eller alt3: {_board[5]} eller alt4: {_board[7]}");
            var myChoise = Console.ReadLine();
            if (myChoise == _board[3] || myChoise == _board[1] || myChoise == _board[5] || myChoise == _board[7])
            {
                int indexOfUserMove = GetIndexOfUserInput(myChoise);
                MakeMove(indexOfEmptySquare, indexOfUserMove);
            }
            else
            {
                DrawBoard();
            }
        }

        if(indexOfEmptySquare == 5)
        {
            Console.WriteLine($"Hvor vil du flytte alt1: {_board[4]} eller alt12 {_board[2]} eller alt3: {_board[8]}");
            var myChoise = Console.ReadLine();
            if (myChoise == _board[4] || myChoise == _board[2] || myChoise == _board[8])
            {
                int indexOfUserMove = GetIndexOfUserInput(myChoise);
                MakeMove(indexOfEmptySquare, indexOfUserMove);
            }
            else
            {
                DrawBoard();
            }
        }

        if(indexOfEmptySquare == 6)
        {
            Console.WriteLine($"Hvor vil du flytte alt1: {_board[3]} eller alt2: {_board[7]}");
            var myChoise = Console.ReadLine();
            if (myChoise == _board[3] || myChoise == _board[7])
            {
                int indexOfUserMove = GetIndexOfUserInput(myChoise);
                MakeMove(indexOfEmptySquare, indexOfUserMove);
            }
            else
            {
                DrawBoard();
            }
        }

        if(indexOfEmptySquare == 7)
        {
            Console.WriteLine($"Hvor vil du flytte alt1: {_board[6]} eller alt2: {_board[4]} eller alt3: {_board[8]}");
            var myChoise = Console.ReadLine();
            if (myChoise == _board[6] || myChoise == _board[4] || myChoise == _board[8])
            {
                int indexOfUserMove = GetIndexOfUserInput(myChoise);
                MakeMove(indexOfEmptySquare, indexOfUserMove);
            }
            else
            {
                DrawBoard();
            }
        }

        if(indexOfEmptySquare == 8)
        {
            if (_board[0] == "1" && _board[1] == "2" && _board[2] == "3" && _board[3] == "4" && _board[4] == "5" &&
                _board[5] == "6" && _board[6] == "7" && _board[7] == "8")
            {
                Console.WriteLine("Gratulerer du har vunnet spillet");
                Console.WriteLine("Vil du spille igjen? (j/n)");
                var answer = Console.ReadLine();
                if (answer == "j")
                {
                    _board = ["2", " ", "6", "7", "8", "5", "1", "3", "4"];
                    DrawBoard();
                }

                if (answer == "n")
                {
                    Console.WriteLine("Takk for at du spilte");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine($"Hvor vil du flytte alt1: {_board[7]} eller alt12 {_board[5]}");
                var myChoise = Console.ReadLine();
                if (myChoise == _board[7] || myChoise == _board[5])
                {
                    int indexOfUserMove = GetIndexOfUserInput(myChoise);
                    MakeMove(indexOfEmptySquare, indexOfUserMove);
                }
                else
                {
                    DrawBoard();
                }
            }
            
        }
    
    }

    int GetIndexOfUserInput(string myChoise)
    {
        int indexOfUserMove = 0;
        for (int i = 0; i < _board.Length; i++)
        {
            string number = _board[i];
            if (number == myChoise)
            {
                indexOfUserMove = i;
            }
        }

        return indexOfUserMove;
    }

    int GetIndexOfEmtySquere()
    {
        int index = 0;
        for (int i = 0; i < _board.Length; i++)
        {
            string number = _board[i];

            if (number == " ")
            {
                index = i;
            }

        }
            
        return index;
    }
    void MakeMove(int currentIndex, int newIndex)
    {
        
            _board[currentIndex] = _board[newIndex];
            _board[newIndex] = " ";
        

        DrawBoard();
    }



}