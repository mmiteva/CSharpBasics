using System;

class QuotesInStrings
{
    static void Main()
    {
        string strQuote1 = "The \"use\" of quotations causes difficulties.";
        string strQuote2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(strQuote1 + "\n" + strQuote2);
    }
}