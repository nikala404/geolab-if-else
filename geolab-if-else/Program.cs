using geolab_if_else;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Conditionals conditionals = new Conditionals();

        Console.WriteLine(conditionals.typeOfNumber(5));

        Console.WriteLine(conditionals.isNumberEvenOrOdd(22));

        Console.WriteLine(conditionals.IsYearLeap(2024));

        Console.WriteLine(conditionals.studentRate(12));

        conditionals.passwordTester("nika123");

        Console.WriteLine(conditionals.highestNumber(10, 12, 12));

        
        Console.WriteLine(conditionals.calculator());

        Console.WriteLine("Enter Your Age:");
        string age = Console.ReadLine();

        Console.WriteLine(conditionals.legalAgeElection(age));

        Console.WriteLine("Input Time:");
        int hour = Convert.ToInt32(Console.ReadLine());

        conditionals.greetBasedOnTime(hour);

        Console.WriteLine("Input Total Price:");
        double total = Convert.ToDouble(Console.ReadLine());

        conditionals.calculateDiscount(total);

        Console.WriteLine("Input Your Age:");
        int age1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input Country:");
        string country = Console.ReadLine();

        Conditionals.checkPurchaseEligibility(age1, country);

        Console.WriteLine("Your age:");
        int age2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("yearly income:");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("do you have co-applicant (yes or no)?");
        string hasCoApplicant = Console.ReadLine();

        conditionals.checkLoanEligibility(age2, income, hasCoApplicant);


    }


}