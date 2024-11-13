using System;
using System.Collections.Generic;

namespace ArraysCS
{
    internal class NumberCollection
    {
        static int[] numbers = new int[5];

        public static void Run()
        {
            var count = 0;
            while (count < numbers.Length)
            {
                var number = MyConsole.AskForInt(question: "Skriv inn et tall");
                var index = count;
                numbers[index] = number;
                show();
                count++;
            }
        }
        static void show() {

            foreach(var number in numbers)
            {
                Console.Write(number + " ");
            
            }
            Console.WriteLine();
        }
    }
}
