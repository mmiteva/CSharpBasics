using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please enter the company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("The name of the company is {0}.", companyName);

        Console.WriteLine("Please enter the company address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("The address of the company is {0}.", companyAddress);

        Console.WriteLine("Please enter the company phone number:");
        string companyPhone = Console.ReadLine();
        Console.WriteLine("The phone number of the company is {0}.", companyPhone);

        Console.WriteLine("Please enter the company fax number:");
        string companyFax = Console.ReadLine();
        Console.WriteLine("The fax number of the company is {0}.", companyFax);

        Console.WriteLine("Please enter the company web site:");
        string companyWeb = Console.ReadLine();
        Console.WriteLine("The web site of the company is {0}.", companyWeb);

        Console.WriteLine("Please enter the manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("The first name of the manager is {0}.", managerFirstName);

        Console.WriteLine("Please enter the manager last name:");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("The last name of the manager is {0}.", managerLastName);

        Console.WriteLine("Please enter the manager age:");
        int managerAge = int.Parse(Console.ReadLine());
        Console.WriteLine("The age of the manager is {0}.", managerAge);

        Console.WriteLine("Please enter the manager phone number:");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("The phone number of the manager is {0}.", managerPhone);

    }
}