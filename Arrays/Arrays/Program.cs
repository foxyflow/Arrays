using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welocme to Crank Worx medal awards//
            string[] MedalWinners = new string[3];

            Console.WriteLine("Please enter the Gold winner");
            MedalWinners[0] = Console.ReadLine();
            Console.WriteLine("Please enter the silver winner");
            MedalWinners[1] = Console.ReadLine();
            Console.WriteLine("Please enter the bronze winner");
            MedalWinners[2] = Console.ReadLine();

            Console.WriteLine("Which winner do you want to display? 1 for Gold, 2 for Silver, 3 for Bronze");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"The medal winner is: {MedalWinners[userInput - 1]}");
            Console.ReadLine();
            //That wraps up the awards for tonight. Drinks are on me//

            /////The next execise uses a for loop -- don't be scared 
            /////what if we had more than 3 winners -- too much typing////
        }
    }
}
