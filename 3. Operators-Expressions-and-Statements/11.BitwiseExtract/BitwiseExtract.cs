using System;

class BitwiseExtract
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int falseBit = 1 << 3;
        int trueBit = number & falseBit;

        if (trueBit == 0)
        {
            Console.WriteLine("Third bit is '0' " + Convert.ToString(number, 2).PadLeft(16, '0'));
        }
        else
        {
            Console.WriteLine("Third bit is '1' " + Convert.ToString(number, 2).PadLeft(16, '0'));
        }
    }
}