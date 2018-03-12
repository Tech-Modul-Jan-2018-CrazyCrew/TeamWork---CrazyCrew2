using System;

namespace _02.RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //Here we calculate area of rectangle
            double area = width * height;

            //Print area
            Console.WriteLine("{0:f2}", area);

        }
    }
}
