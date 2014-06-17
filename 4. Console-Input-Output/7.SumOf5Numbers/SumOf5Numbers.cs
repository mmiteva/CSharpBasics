using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers: ");
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());
        double number4 = double.Parse(Console.ReadLine());
        double number5 = double.Parse(Console.ReadLine());
        double sum = number1 + number2 + number3 + number4 + number5;

        Console.WriteLine("{0} {1} {2} {3} {4} {5}", number1, number2, number3, number4, number5, sum);
    }
}