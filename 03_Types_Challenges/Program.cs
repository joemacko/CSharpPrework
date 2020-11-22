using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int one;
            int votes = 360;
            Console.WriteLine(votes);

            string firstName = "Joe";
            string lastName = "Macko";
            Console.WriteLine(firstName+lastName);

            bool three;
            bool majority = true;
            Console.WriteLine(majority);

            float four;
            float district = 2.5f;
            Console.WriteLine(district);

            double five;
            double districtCode = 2.8749237474d;
            Console.WriteLine(districtCode);

            decimal six;
            decimal percentVote = 51.4857539857289958393m;
            Console.WriteLine(percentVote);

            int yob = 1988;
            string str = Convert.ToString(yob);
            Console.WriteLine(yob);

            Console.ReadLine();
        }
    }
}
