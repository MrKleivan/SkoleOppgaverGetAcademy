namespace Emne3Oppgaver.Oppgave321C;

public class Oppgave321C
{
    public void Run()
    {
        
            var coinInventory = new CoinInventory
            {
                MyCoinS =
                [
                    new Coin
                    {
                        Value = 1,
                        Amount = 7,
                    },
                    new Coin
                    {
                        Value = 5,
                        Amount = 3
                    },
                    new Coin
                    {
                        Value = 10,
                        Amount = 2
                    },
                    new Coin
                    {
                        Value = 20,
                        Amount = 12
                    }
                ]
            };
        
        foreach (var t in coinInventory.MyCoinS)
        {
            Console.WriteLine($"Total sum av {t.Value}kroninger er: {t.Total}");
        }
        int total = coinInventory.MyCoinS.Sum(x => x.Total);
        Console.WriteLine($"Total sum er: {total}");
    }
}