using System;

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Mariya";
            string lastName = "Miteva";
            byte age = 31;
            char gender = 'f';
            ulong idNumber = 8306112507;  
            int employeeNumber = 27560000;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", firstName, lastName, age, gender, idNumber, employeeNumber);
        }
    }