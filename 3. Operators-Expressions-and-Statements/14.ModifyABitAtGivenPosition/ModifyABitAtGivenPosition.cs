using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check the bit at the position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("A bit value (0 or 1): ");
        int bitValue = int.Parse(Console.ReadLine());
 
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
 
        if (bitValue == 1)
        {
            int setOne = 1 << position;
            int foundBitOne = number | setOne;
            Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBitOne);
        }
        else
        {
            int setZero = ~(1 << position);
            int foundBitZero = number & setZero;
            Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBitZero);
        }
    }
}