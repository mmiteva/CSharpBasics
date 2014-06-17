using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter the year you were born in:");
            int yearOfBirth = int.Parse(Console.ReadLine());
            DateTime currentYear = DateTime.Now;
            DateTime futureYear = currentYear.AddYears(10);
            Console.WriteLine("After 10 years you will be " + (futureYear.Year - yearOfBirth) + " years old!");
        }
    }