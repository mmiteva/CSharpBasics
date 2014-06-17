﻿using System;

class PlayWithIntDoubleString
{
    static void Main()
    {

        Console.WriteLine("Choose what kind of variable you would like to enter.");
        Console.Write("For int press 1, for double - 2 and for string - 3: ");
        string userInput = Console.ReadLine();
        byte userChoice;
        bool check = byte.TryParse(userInput, out userChoice);
        bool isInputCorrect;

        if (check)
        {
            switch (userChoice)
            {
                case 1:
                    Console.Write("Enter your int variable: ");
                    long intChoice;
                    isInputCorrect = long.TryParse(Console.ReadLine(), out intChoice);
                    if (isInputCorrect)
                    {
                        Console.WriteLine(intChoice + 1);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input! Please Try again!");
                        Main();
                    }
                    break;
                case 2:
                    Console.Write("Enter your double variable: ");
                    double doubleChoice;
                    isInputCorrect = double.TryParse(Console.ReadLine(), out doubleChoice);
                    if (isInputCorrect)
                    {
                        Console.WriteLine(doubleChoice + 1.0);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input! Please Try again!");
                        Main();
                    }
                    break;
                case 3:
                    Console.Write("Enter your string variable: ");
                    string strChoice = Console.ReadLine();
                    Console.WriteLine(strChoice + "*");
                    break;
                default:
                    Console.WriteLine("Incorrect input! Please Try again!");
                    Main();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Incorrect input! Please Try again!");
            Main();
        }

    }
}