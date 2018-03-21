//CONFIRMED from petko-dimitrov

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
			// Read first number from the console.
            int first = int.Parse(Console.ReadLine());
			// Read second number from the console.
            int secound = int.Parse(Console.ReadLine());
			// Read third number from the console.
            int third= int.Parse(Console.ReadLine());
			// Read fourth number from the console.
            int fourth = int.Parse(Console.ReadLine());
			
			// Print the numbers. 
            Console.WriteLine($"{first:D4} {second:D4} {third:D4} {fourth:d4}");
        }
    }
}
