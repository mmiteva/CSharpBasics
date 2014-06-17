using System;

class PointInACircle
{
    static void Main()
    {
        double radius = 2;

        Console.WriteLine("Enter the abscissa:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ordinate:");
        double y = double.Parse(Console.ReadLine());

        double givenPoint = Math.Sqrt((x * x) + (y * y));

        Console.WriteLine(givenPoint <= radius ? "The Point is inside the circle K.": "The Point is ouside the circle K.");
    }
}