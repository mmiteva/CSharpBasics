using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number:");
        int intNumber = int.Parse(Console.ReadLine());
        int residualNumber = intNumber / 100;
        int thirdDigit = residualNumber % 10;

        bool isThirdDigitSeven = thirdDigit == 7;

        Console.WriteLine("Third didgit of the entered number is 7: {0}.", isThirdDigitSeven);
    }
}