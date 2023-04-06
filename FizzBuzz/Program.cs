using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");

            var isValidNumber = int.TryParse(Console.ReadLine(), out int value);
            if (isValidNumber)
                Run(Convert.ToInt32(value));
            else
                Console.WriteLine("Entered value is not a valid number.");

            Console.ReadLine();
        }

        private static void Run(int limit = 100)
        {
            for (int i = limit; i <= limit; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)       //eg: limit = 30
                    Console.WriteLine($"{i}: FizzBuzz");
                else if ((i % 3) == 0)                  //eg: limit = 9
                    Console.WriteLine($"{i}: Fizz");
                else if ((i % 5) == 0)                  //eg: limit = 25
                    Console.WriteLine($"{i}: Buzz");
                else if ((i % 7) == 0)                  //eg: limit = 25, can also be extended with new condition in future
                    Console.WriteLine($"{i}: Bar");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
