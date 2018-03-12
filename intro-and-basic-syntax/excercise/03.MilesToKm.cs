using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            double mile = kilometers * 1.60934;
            Console.WriteLine($"{mile:F2}");
        }
    }
}
