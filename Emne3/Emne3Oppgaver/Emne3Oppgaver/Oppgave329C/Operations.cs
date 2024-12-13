namespace Emne3Oppgaver.Oppgave329C;

public class Operations
{
    string resultForFour = "";
    string resultForTwo = "";
    int resultCountForFour = 0;
    int resultCountForTwo = 0;
    public void FindSolutionOpperation(Bottle[] bottles)
    {
        for (int i = 0; i < 8; i++)
        {
            bottles[0] = new Bottle(3);
            bottles[1] = new Bottle(5);
            
            
            if (i == 0)
            {
                bottles[0].FillBottleFromSink();
            }  
            else if (i == 1)
            {
                bottles[1].FillBottleFromSink();
            }
            else if (i == 2)
            {
                bottles[0].EmptyThisBottleInOtherBottle(bottles[1]);
            }
            else if (i == 3)
            {
                bottles[1].EmptyThisBottleInOtherBottle(bottles[0]);
            }
            else if (i == 4)
            {
                bottles[1].FillOtherBottleWithThisBottle(bottles[0]);
            }
            else if (i == 5)
            {
                bottles[0].FillOtherBottleWithThisBottle(bottles[1]);
            }
            else if (i == 6)
            {
                bottles[0].EmptyThisBottle();
            }
            else if (i == 7)
            {
                bottles[1].EmptyThisBottle();
            }
            var bottleOne = bottles[0].VolumeTaken;
            var bottleTwo = bottles[1].VolumeTaken;
            
            for (int j = 0; j < 8; j++)
            {
                bottles[0].VolumeTaken = bottleOne;
                bottles[1].VolumeTaken = bottleTwo;
                if (j == 0)
                {
                    bottles[0].FillBottleFromSink();
                }  
                else if (j == 1)
                {
                    bottles[1].FillBottleFromSink();
                }
                else if (j == 2)
                {
                    bottles[0].EmptyThisBottleInOtherBottle(bottles[1]);
                }
                else if (j == 3)
                {
                    bottles[1].EmptyThisBottleInOtherBottle(bottles[0]);
                }
                else if (j == 4)
                {
                    bottles[0].FillOtherBottleWithThisBottle(bottles[1]);
                }
                else if (j == 5)
                {
                    bottles[1].FillOtherBottleWithThisBottle(bottles[0]);
                }
                else if (j == 6)
                {
                    bottles[0].EmptyThisBottle();
                }
                else if (j == 7)
                {
                    bottles[1].EmptyThisBottle();
                }

                if (bottles[0].VolumeTaken == 4)
                {
                    resultCountForFour++;
                    resultForFour += $"Løsning: {i.ToString()} - {j.ToString()}\n";
                    
                }
                if (bottles[0].VolumeTaken == 2 || bottles[1].VolumeTaken == 2)
                {
                    resultCountForTwo++;
                    resultForTwo += $"Løsning: {i.ToString()} - {j.ToString()}\n";
                }
                
                
                
            }
        }
        Console.WriteLine("Løsning for å få 4 liter: \n" + resultForFour + "Totalt antall løsninger:" + resultCountForFour.ToString());
        Console.WriteLine("************************************************");
        Console.WriteLine("Løsning for å få 2 liter: \n" + resultForTwo + "Totalt antall løsninger:" + resultCountForTwo.ToString());
    }
}