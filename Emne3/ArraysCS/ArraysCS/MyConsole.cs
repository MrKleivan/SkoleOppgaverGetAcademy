using System.Security.Principal;

namespace ArraysCS
{
    internal class MyConsole
    {
        public static string Ask(string question)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Press any key to continue");
            Console.ReadKey();
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        public static int AskForInt(string question)
        {
            var answerStr = Ask(question);
            return Convert.ToInt32(answerStr);
        }

        public static bool AskForBool(string question)
        {
            var answerStr = Ask(question + " (j/n)");
            return answerStr.ToLower().StartsWith("j");
        }
    }
}
