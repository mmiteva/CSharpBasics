using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? intValue = null;
            double? doubleValue = null;
            Console.WriteLine("Printing the values as null:");
            Console.WriteLine("Integer as null: {0}\nDouble as null: {1}", intValue, doubleValue);
            Console.WriteLine(Environment.NewLine);
         
            Console.WriteLine("Adding 2 to both values:");
            intValue += 2;
            doubleValue += 2;
            Console.WriteLine("Integer after adding: {0}\nDouble after adding: {1}", intValue, doubleValue);
        }
    }