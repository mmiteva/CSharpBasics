using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int[] colours = { 3, 4, 5, 6 };

        foreach (var card in cards)
        {
            foreach (var colour in colours)
            {
                Console.Write(card);
                Console.Write((char)colour + " ");
            }

            Console.WriteLine();
        }
    }
}