namespace Emne3Oppgaver.Oppgave329C;

public class Bottle
{
    public int Volume;
    public int VolumeTaken;

    public Bottle(int capacity)
    {
        Volume = capacity;
        // VolumeTaken = capacity < VolumeTaken ? capacity : VolumeTaken;
    }

    public void FillBottleFromSink(Bottle bottle)
    {
        bottle.VolumeTaken = bottle.Volume;
    }

    public void EmptyThisBottleInOtherBottle(Bottle otherBottle)
    {
        otherBottle.VolumeTaken += VolumeTaken;
        VolumeTaken = 0;
        if (otherBottle.VolumeTaken > otherBottle.Volume)
        {
            otherBottle.VolumeTaken = otherBottle.Volume;
        }
    }
    
    public void EmptyOtherBottleInThisBottle(Bottle otherBottle)
    {
        VolumeTaken += otherBottle.VolumeTaken;
        otherBottle.VolumeTaken = 0;
        if (VolumeTaken > Volume)
        {
            VolumeTaken = Volume;
        }
    }

    public void FillThisBottleFromOtherBottle(Bottle otherBottle)
    {
        VolumeTaken += otherBottle.VolumeTaken;
        if (VolumeTaken > Volume)
        {
            otherBottle.VolumeTaken = VolumeTaken - Volume;
            VolumeTaken = Volume;
        }
    }

    public void FillOtherBottleWithThisBottle(Bottle otherBottle)
    {
        otherBottle.VolumeTaken += VolumeTaken;
        if (otherBottle.VolumeTaken > otherBottle.Volume)
        {
            VolumeTaken = otherBottle.VolumeTaken - otherBottle.Volume;
            otherBottle.VolumeTaken = otherBottle.Volume;
        }
    }

    public void EmptyThisBottle()
    {
        VolumeTaken = 0;
    }
    
    public void EmptyOtherBottle(Bottle otherBottle)
    {
        otherBottle.VolumeTaken = 0;
    }
}

