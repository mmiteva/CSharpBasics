using System;

class SumOfThreeIntegers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int sum = (a + b + c);

        Console.WriteLine("The sum of the three integer numbers is {0}.", sum);
    }
}