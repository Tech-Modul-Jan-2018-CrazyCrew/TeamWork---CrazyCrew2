using System;

namespace _02.RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectangleArea = width * height;

            Console.WriteLine("{0:f2}", rectangleArea);
        }
    }
}
