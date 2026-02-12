using System;
using System.Globalization;
using TriangleCalculatorWithClass;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.Write("Enter the measurements of the triangle x:\n\nSide A(meters): ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side B(meters): ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side C(meters): ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nEnter the measurements of the triangle y:\n\nSide A(meters): ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side B(meters): ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side C(meters): ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("\nArea of the triangle x = " + areaX.ToString("F4", CultureInfo.InvariantCulture) + " meters");
            Console.WriteLine("Area of the triangle y = " + areaY.ToString("F4", CultureInfo.InvariantCulture) + " meters");

            if (areaX > areaY)
            {
                Console.WriteLine("\nLargest area: triangle X");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("\nLargest area: triangle Y");
            }
            else
            {
                Console.WriteLine("\nThe two triangles have the same area");
            }
        }

    }
}
