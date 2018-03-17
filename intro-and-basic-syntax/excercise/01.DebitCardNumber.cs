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
			// Read four numbers from the console.
            int first = int.Parse(Console.ReadLine());
            int secound = int.Parse(Console.ReadLine());
            int third= int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
			
			// Print the numbers. 
            Console.WriteLine($"{first:D4} {second:D4} {third:D4} {fourth:d4}");
        }
    }
}
