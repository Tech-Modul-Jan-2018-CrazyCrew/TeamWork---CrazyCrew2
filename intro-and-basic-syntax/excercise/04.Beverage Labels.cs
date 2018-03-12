using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is  input
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyPer100 = double.Parse(Console.ReadLine());
            double sugarPer100 = double.Parse(Console.ReadLine());
            //Here we calculate calories
            double energy = energyPer100 * volume / 100;
            double sugar = sugarPer100 * volume / 100;
            //This is output
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
