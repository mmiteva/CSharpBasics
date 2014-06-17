using System;

class DivideBy7And5
{
    static void Main()
    {
        int sampleNumber = int.Parse(Console.ReadLine());
        bool divider = (sampleNumber % 5 == 0) && (sampleNumber % 7 == 0);
        Console.WriteLine("The number can be divided by 5 and 7 in the same time:" + divider);
    }
}