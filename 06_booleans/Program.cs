using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSad = false;
            Console.WriteLine(isSad);

            bool isHappy = true;
            Console.WriteLine(isHappy);

            int value = 100 / 3;
            //1
            if (value == 50)
            {
                //2
                Console.WriteLine(true);
            }

            //3
            Console.WriteLine("Since I'm not in the if block, I'll always display.");

            Console.ReadLine();
        }
    }
}
