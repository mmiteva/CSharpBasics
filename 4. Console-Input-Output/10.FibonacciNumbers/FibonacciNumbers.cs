using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a random number:");
        int number = int.Parse(Console.ReadLine());
        int fibonacciNumber;
        int startNumber = 0;
        int secondNumber = 1;

        if (number == 1)
        {
            Console.WriteLine(0);
        }
        else if (number == 0)
        {
            Console.WriteLine("Thete is no sequence.");
        }
        else
        {
            Console.Write(0 + ", " + 1 + ", ");
            for (int i = 0; i < number - 2; i++)
            {
                fibonacciNumber = startNumber + secondNumber;
                Console.Write(fibonacciNumber + ", ");
                startNumber = secondNumber;
                secondNumber = fibonacciNumber;
            }
        }
    }
}