﻿using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number%2 == 0)
        {
            Console.WriteLine("FALSE");
        }
        else
        {
            Console.WriteLine("TRUE");
        }
    }
}
