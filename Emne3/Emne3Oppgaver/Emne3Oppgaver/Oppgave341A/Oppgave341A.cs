namespace Emne3Oppgaver.Oppgave341A;

public class Oppgave341A
{
    public void Run()
    {
        BlinkingStar star1 = new BlinkingStar(4, 7);
        MovingStar star2 = new MovingStar(7, 4);

        IStar[] stars = new IStar[]
        {
            star1,
            star2
        };


        while (true)
        {
            Console.Clear();
            foreach (var star in stars)
            {
                star.Show();
                star.Update();
            }
            Console.SetCursorPosition(5, 10);
            Thread.Sleep(200);
        }
    }
}