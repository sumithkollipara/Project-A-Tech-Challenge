using System;

namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");

            var isValidNumber = int.TryParse(Console.ReadLine(), out int value);
            if (isValidNumber)
                Pyramid(Convert.ToInt32(value));
            else
                Console.WriteLine("Entered value is not a valid number.");

            Console.ReadLine();            
        }

        private static void Pyramid(int height)
        {
            for (int i = 0; i < height; i++)
            {
                Console.Write(new String(' ', height - i - 1));
                Console.Write(new String('*', i * 2 + 1));
                Console.WriteLine();
            }
        }
    }
}
