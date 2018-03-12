using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
			// Read the kilometers from the console.
            double kilometers = double.Parse(Console.ReadLine());
			
			// Convert kilometers to miles.
            double mile = kilometers * 1.60934;
			
			// Print the result.
            Console.WriteLine($"{mile:F2}");
        }
    }
}
