using geolab_if_else;

internal class Program
{
    private static void Main(string[] args)
    {
        Conditionals conditionals = new Conditionals();

        Console.WriteLine(conditionals.typeOfNumber(5));
        Console.WriteLine(conditionals.isNumberEvenOrOdd(22));
        Console.WriteLine(conditionals.IsYearLeap(2024));
        Console.WriteLine(conditionals.studentRate(12));

        Console.WriteLine("Enter your password:");
        string input = Console.ReadLine();
        conditionals.passwordTester("nika123", input);   




    }

  
}