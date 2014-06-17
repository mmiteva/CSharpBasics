using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers:");
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());


        if (a > b && a > c)
        {
            Console.WriteLine("{0}", a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("{0}", b);
        }
        else
        {
            Console.WriteLine("{0}", c);
        }
    }
}