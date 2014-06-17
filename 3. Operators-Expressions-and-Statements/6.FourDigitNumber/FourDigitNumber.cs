using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a four-digit number, as it cannot start with 0.");
        string inputNumber = Console.ReadLine();
        int number = int.Parse(inputNumber);
 
        int a = number / 1000;
        a %= 10;
 
        int b = number / 100;
        b %= 10;
 
        int c = number / 10;
        c %= 10;
 
        int d = number % 10;
 
        int sumOfDigits = a + b + c + d;
        Console.WriteLine("The sum of the digits is {0}", sumOfDigits);
        Console.WriteLine("Your number in reversed order is " + d + c + b + a);
        Console.WriteLine("Your number with last digit in front is " + d + a + b + c);
        Console.WriteLine("Your number with second and third digits exchanged is " + a + c + b + d);
    }
}