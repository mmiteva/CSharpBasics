using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers:");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double greater = Math.Max(firstNumber, secondNumber);
       
        Console.WriteLine("The greater number is {0}.", greater);
    }
}