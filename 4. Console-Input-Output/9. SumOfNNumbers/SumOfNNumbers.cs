using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a random number:");
        int number = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("n = ");
            sum = sum + int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is: {0}.", sum);
    }
}