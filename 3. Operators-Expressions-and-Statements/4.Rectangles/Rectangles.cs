using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please enter sample values for width and height:");
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2 * width) + (2 * height);
        double area = width * height;    
        Console.WriteLine("The perimeter and the area of the respective rectangle is as follows: {0} and {1}.", perimeter, area);
    }
}