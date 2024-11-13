namespace Oppgave315A;

public class CheckNumber
{
    static int computerNumber = Convert.ToInt32(GameNumber.GetRandomNumber());
    public static void CheckMyNumber()
    {

    Console.WriteLine("Skriv inn et tall");
        int numberInput = Convert.ToInt32(Console.ReadLine());
        
        if (numberInput == computerNumber)
        {
            Console.WriteLine($"Du valgte {numberInput} og dataen har valgt {computerNumber} du vant!");
            Console.WriteLine("Vil du spille på nytt? (j/n)");
            var YourAnswer = Console.ReadLine();
            var Svar = "Takk for spillet";
            if (YourAnswer == "j")
            {
                computerNumber = Convert.ToInt32(GameNumber.GetRandomNumber());
                CheckMyNumber();
            }
            else Console.WriteLine("Takk for spillet");
            return ;
        } 
        if (numberInput < computerNumber)
        {
            Console.WriteLine($"Du valgte {numberInput} dette er for lavt");
            CheckMyNumber();
        }
        if (numberInput > computerNumber)
        {
            Console.WriteLine($"Du valgte {numberInput} dette er for høyt");
            
            CheckMyNumber();
        }
    }
}