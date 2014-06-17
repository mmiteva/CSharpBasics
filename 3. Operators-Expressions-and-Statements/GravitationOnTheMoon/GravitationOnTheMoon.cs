using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Please, enter your weight:");
        double weight = double.Parse(Console.ReadLine());
        double WeightOnTheMoon = (weight * 0.17); 
        Console.WriteLine(WeightOnTheMoon);
    }
}