using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_continued
{
    class Program
    {
        static void Main(string[] args)
            ////////////////Arrays//////////////Luke Fox////////////////////////////Exercise 2/////////
        {
            string[] names = new string[5];
            //note don't write i<= 5; (in the middle of the for loop) as array starts at zero
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"enter name {i + 1}");//// note the +1 so the console doesn't start at 0
                names[i] = Console.ReadLine();
            }
            Console.ReadLine();
            ///////////////////or///////////////////////
            ////////////////////////
            string[] namesAgain = new string[5];

            for (int z = 0; z < namesAgain.Length; z++)   
            {
                Console.WriteLine($"enter name {z + 1}");///note the plus one to start at one not zero
                namesAgain[z] = Console.ReadLine();
            }
            Console.WriteLine($"the first name entered was:{namesAgain [0]}");
            Console.WriteLine($"The last on the list was {namesAgain[4]}");
            Console.ReadLine();


        }
        
    }
}
