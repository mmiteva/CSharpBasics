﻿using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}