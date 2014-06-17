using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Mariya";
            string middleName = "Dimitrova";
            string lastName = "Miteva";
            decimal balance = 1200300.459m;
            string bankName = "HypoVereinsbank";
            string IBAN = "DE40 7002 0270 0012 3456 78";
            ulong cardNumber1 = 5678912589999;
            ulong cardNumber2 = 3298264788991;
            ulong cardNumber3 = 2689546222222;
            Console.WriteLine("{0} {1} {2}\nAccount balance: {3}\n{4} IBAN: {5}\nCard number 1: {6}\nCard number 2: {7}\nCard number 3: {8}", firstName, middleName, lastName, balance, bankName, IBAN, cardNumber1, cardNumber2, cardNumber3);

        }
    }