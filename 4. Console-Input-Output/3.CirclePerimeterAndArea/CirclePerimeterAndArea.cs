using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI*radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("The perimeter of the circle is {0:F2}", perimeter);
        Console.WriteLine("The area of the circle is {0:F2}", area);
    }
}