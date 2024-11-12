namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            for (int i = 0; i < args.Length; i++)
            {

                Console.WriteLine(args[i]);
            }
        }
    }
}
