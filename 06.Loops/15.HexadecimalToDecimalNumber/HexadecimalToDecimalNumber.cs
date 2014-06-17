using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Hexadecimal:");
        string hexNumber = Console.ReadLine();
        long decNumber = 0;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            long number;
            long power = 1;
            switch (hexNumber[i])
            {
                case 'A':
                    number = 10;
                    break;
                case 'B':
                    number = 11;
                    break;
                case 'C':
                    number = 12;
                    break;
                case 'D':
                    number = 13;
                    break;
                case 'E':
                    number = 14;
                    break;
                case 'F':
                    number = 15;
                    break;
                default:
                    number = (long)hexNumber[i] - 48;
                    break;
            }
            for (int q = hexNumber.Length - 1; q > i; q--)
            {
                power *= 16;
            }
            decNumber += number * power;
        }

    }
}