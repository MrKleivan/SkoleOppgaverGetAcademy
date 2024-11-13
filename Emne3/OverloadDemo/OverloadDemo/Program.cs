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

        static void SetColor(int red, int green, int blue)
        {

        }

        static void SetColor(string colorName)
        {
            if(colorName=="white")SetColor(red: 255, green: 255, blue: 255);
            else if(colorName=="black")SetColor(red: 0, green: 0, blue: 0);
        }
    }
}
