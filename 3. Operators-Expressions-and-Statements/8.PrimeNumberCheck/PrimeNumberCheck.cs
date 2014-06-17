using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int intNumber = int.Parse(Console.ReadLine());
        int dividedByTwo = intNumber / 2;
        int dividedByThree = intNumber / 3;
        int dividedByFive = intNumber / 5;
        if (intNumber > 0)
        {
            Console.WriteLine((intNumber != 2 && intNumber == dividedByTwo * 2) || (intNumber != 3 && intNumber == dividedByThree * 3) || (intNumber != 5 && intNumber == dividedByFive * 5) ? intNumber + " is not a prime number." : intNumber + " is a prime number.");
        }
        else Console.WriteLine(intNumber + " is not a prime number.");
        Main();
    }
}