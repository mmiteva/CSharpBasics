﻿using System;

class NumNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
