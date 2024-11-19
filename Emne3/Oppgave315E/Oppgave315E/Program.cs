
Console.WriteLine("skriv inn 3 tall for start");
var userNumberInput = Console.ReadLine().Split(' ');

CreateNumberList(userNumberInput);
static void CreateNumberList(string[] numberS)
{
    for (int i = int.Parse(numberS[0]); i <= int.Parse(numberS[2]); i = i + int.Parse(numberS[1]))
    {
        Console.Write($"{i.ToString()} ");
    }
}
