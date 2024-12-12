namespace Emne3Oppgaver.Oppgave329C;

public class Oppgave329C
{
    public static void Run()
    {
        var bottles = new Bottle[2];
        bottles[0] = new Bottle(3);
        bottles[1] = new Bottle(5);

        // bottles[0].FillBottleFromSink();
        // bottles[1].FillBottleFromSink();
        // bottles[0].FillThisBottleFromOtherBottle(bottles[1]);
        // bottles[1].EmptyThisBottleInOtherBottle(bottles[0]);

        for (int i = 0; i < 2; i++)
        {
            bottles[0] = new Bottle(3);
            bottles[1] = new Bottle(5);
            
            bottles[i].FillBottleFromSink(bottles[i]);
            bottles[i == 1 ? 0 : 1].FillBottleFromSink(bottles[i == 1 ? 0 : 1]);
            bottles[i].EmptyThisBottleInOtherBottle(bottles[i == 1 ? 0 : 1]);
            bottles[i].EmptyThisBottleInOtherBottle(bottles[i == 1 ? 0 : 1]);
            
        }
        
        Console.WriteLine(bottles[0].Volume + ", " + bottles[0].VolumeTaken);
        Console.WriteLine(bottles[1].Volume + ", " + bottles[1].VolumeTaken);

    }
    
}