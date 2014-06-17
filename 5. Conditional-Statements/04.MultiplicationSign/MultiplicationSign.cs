using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers:");
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal result = a * b * c;

        if (result > 0)
        {
            Console.WriteLine("+");
        }
        else if (result < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("0");
        }

    }
}