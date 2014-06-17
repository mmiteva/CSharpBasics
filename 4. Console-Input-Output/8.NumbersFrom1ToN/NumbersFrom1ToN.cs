using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number:");
        int intNumber = int.Parse(Console.ReadLine());

        for (int number = 1; number <= intNumber; number++)
        {
            Console.WriteLine(number);
        }
    }
}