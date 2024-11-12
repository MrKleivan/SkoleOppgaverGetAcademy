namespace JS2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = MyConsole.Ask(question: "Hva heter du?");
            Console.WriteLine($"Hei {name}");

            var birthYear = MyConsole.AskForInt("I hvilket år ble du født;");
            var hadBirthDay = MyConsole.AskForBool("Har du hat bursdag i år?");
            var age = 2024 - birthYear;
            if (!hadBirthDay == true) age--;
            Console.WriteLine($"Da er du {age} år gammel");
        }

        
    }
}