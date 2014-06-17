using System;

class ComparingFloats
{
    static void Main()
    {
        float eps = 0.000001F;
        bool aftermath = true;

        Console.WriteLine("Enter a number for comparison");
        double firstNumber = Math.Abs(double.Parse(Console.ReadLine()));
        Console.WriteLine("Enter a number for comparison");
        double secondNumber = Math.Abs(double.Parse(Console.ReadLine()));

        if (firstNumber > secondNumber)
        {
            aftermath = firstNumber - secondNumber < eps;
        }
        else
        {
            aftermath = secondNumber - firstNumber < eps;
        }

        Console.WriteLine(aftermath);
    }
}