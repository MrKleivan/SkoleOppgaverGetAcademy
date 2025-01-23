using System.Text.Json;

namespace ObligEmne3;

public class CountryCodeConsole
{
    private static readonly string[] _countryCodes;
    private readonly string _question;

    static CountryCodeConsole()
    {
        var json = File.ReadAllText("../../../JSON/countryCodes.json");
        _countryCodes = JsonSerializer.Deserialize<string[]>(json);
    }

    public CountryCodeConsole(string question)
    {
        _question = question;
    }

    public string AskForCountry()
    {
        string input = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine(_question);
            var message = input == ""
                ? "(skriv første bokstav i landets kode.)"
                : "(skriv andre bokstav - eller backspace.)";
            Console.WriteLine(message);
            if (input.Length == 1)
            {
                for (var i = 0; i < _countryCodes.Length; i += 2)
                {
                    if (_countryCodes[i].StartsWith(input))
                    {
                        Console.WriteLine(_countryCodes[i] + " - " + _countryCodes[i + 1]);
                    }
                }

                Console.Write(input);
            }
            var consoleKeyInfo = Console.ReadKey(true);
            var keyChar = char.ToUpper(consoleKeyInfo.KeyChar);
            if (consoleKeyInfo.Key == ConsoleKey.Backspace && input.Length == 1)
            {
                input = "";
            }
            else if (char.IsLetter(keyChar))
            {
                if (input.Length == 1)
                {
                    var code = input + keyChar;
                    for (var i = 0; i < _countryCodes.Length; i += 2)
                    {
                        if (code == _countryCodes[i])
                        {
                            Console.WriteLine(keyChar);
                            return _countryCodes[i + 1];
                        }
                    }
                }
                else
                {
                    input += keyChar;
                }
            }
        }
    }
}