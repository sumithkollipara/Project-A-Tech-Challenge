using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");
            Run(Convert.ToInt32(Console.ReadLine()));
        }

        private static void Run(int limit = 100)
        {
            for (int i = limit; i <= limit; i++)
            {
                string output;
                if ((i % 3) == 0 && (i % 5) == 0)
                    output = "FizzBuzz";
                else if ((i % 3) == 0)
                    output = "Fizz";
                else if ((i % 5) == 0)
                    output = "Buzz";
                else if ((i % 7) == 0) //can also be extended with new condition
                    output = "Bar";
                else
                    output = i.ToString();

                Console.WriteLine($"{i}: {output}");
            }

            Console.ReadLine();
        }
    }
}
