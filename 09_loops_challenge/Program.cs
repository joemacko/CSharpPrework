using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze Challenge //
            int numberb = 525;
            for (int b = 500; b <= numberb; b++)
                Console.WriteLine(b);
            
            // Silver Challenge //
            int numbers = 100;
            for (int s = 5; s <= numbers; s += 5)
                Console.WriteLine(s);

            // Gold Challenge //
            int numberg = 100;
            for (int g = 1; g <= numberg; g++)
                if (g % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (g % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (g % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(g);
                }
        }
    }
}
