using System;

class QuadraticEquation
{
    static void Main()
    {
        double coeffA = double.Parse(Console.ReadLine());
        double coeffB = double.Parse(Console.ReadLine());
        double coeffC = double.Parse(Console.ReadLine());
        double determinant = (coeffB * coeffB) - (4 * coeffA * coeffC);

        if (determinant < 0)
        {
            Console.WriteLine("Determinant < 0 - > No real roots.");
        }
        else if (determinant > 0)
        {
            Console.WriteLine("x1 = {0}", (-coeffB - Math.Sqrt(determinant)) / (2 * coeffA));
            Console.WriteLine("x2 = {0}", (-coeffB + Math.Sqrt(determinant)) / (2 * coeffA));
        }
        else
        {
            Console.WriteLine("DETERMINANT = 0 - > x1 = x2 = {0}", (-coeffB / (2 * coeffA)));
        }
    }
}