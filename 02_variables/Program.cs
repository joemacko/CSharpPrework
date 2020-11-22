using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Paul";
            Console.WriteLine(firstName);
            //1       //2
            string lastName = "Johnson";
            Console.WriteLine(lastName);

            int birthYear = 1990; // Not initialized
                                  //3
            Console.WriteLine(birthYear);

            Console.ReadLine();
        }
    }
}
