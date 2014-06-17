using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an index p:");
        int p = int.Parse(Console.ReadLine());
        string convert = Convert.ToString(number, 2).PadLeft(16, '0');
        Console.WriteLine("Binary representation: {0}", convert);
        int secondNumber = Convert.ToInt32(convert);
        int mask = 1;
        mask = mask << p;
        int secondmask = number & mask;

        if (secondmask != 0)
        {

            Console.WriteLine("Bit position of {0} is 1.", p);
        }
        else
        {
            Console.WriteLine("Bit position of {0} is 0.", p);
        }
    }
}