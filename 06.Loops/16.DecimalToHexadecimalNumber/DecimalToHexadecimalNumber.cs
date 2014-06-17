using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Decimal:");
        long decNumber = long.Parse(Console.ReadLine());
        string hexNumber = "";
        while (decNumber >= 1)
        {
            char number;
            switch (decNumber % 16)
            {
                case 15:
                    number = 'F';
                    break;
                case 14:
                    number = 'E';
                    break;
                case 13:
                    number = 'D';
                    break;
                case 12:
                    number = 'C';
                    break;
                case 11:
                    number = 'B';
                    break;
                case 10:
                    number = 'A';
                    break;
                default:
                    long temp = decNumber % 16 + 48;
                    number = (char)temp;
                    break;
            }
            hexNumber = number + hexNumber;
            decNumber /= 16;
        }
        Console.WriteLine(hexNumber);
    }
}