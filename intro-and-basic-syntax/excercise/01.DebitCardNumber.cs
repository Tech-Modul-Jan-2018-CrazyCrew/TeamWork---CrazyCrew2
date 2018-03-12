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
            int first = int.Parse(Console.ReadLine());
            int secound = int.Parse(Console.ReadLine());
            int third= int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            Console.WriteLine($"{first:D4} {secound:D4} {third:D4} {fourth:d4}");
        }
    }
}
