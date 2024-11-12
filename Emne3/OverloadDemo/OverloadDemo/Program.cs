namespace OverloadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greet(name: "Per", greting: "Hei");
            Greet(name: "Kleivan", greting: "Halloy");
            Greet(name: "Kalle");
            Greet();
        }

        static void Greet(string name, string greting)
        {
            Console.WriteLine($"{greting}, {name}!");
        }
        static void Greet(string name)
        {
            Greet(name, greting: "Hei");
        }

        static void Greet()
        {
            Greet(name: "på deg");
        }

        static void SetColor(string colorName)
        {
            if(colorName== "white")SetColor(255,255,255);
        }
    }
}
