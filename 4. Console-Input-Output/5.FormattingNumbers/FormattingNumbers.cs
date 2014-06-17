using System;
using System.Threading;
using System.Globalization;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("а=");
        int a = int.Parse(Console.ReadLine());
       
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());

        if (a <= 500 & a >= 0)
        {
            Console.Write("|{0,-10:X}|{1}", a, Convert.ToString(a, 2).PadLeft(10, '0'));
           
            bool checkB = Convert.ToString(b).IndexOf(".") > 0;
            Console.Write(checkB ? "|{0,10:F2}" : "|{0,10}", b);

            bool checkC = Convert.ToString(c).IndexOf(".") > 0;
            Console.WriteLine(checkC ? "|{0,-10:F3}|" : "|{0,10}|", c);
        }
        else
        {
            Console.WriteLine("The number \"a\" is not between 0 <= a <= 500.");
        }

        

    }
}