namespace Frogmi.utils;

public class Validators
{
    public static int EnterANumber()
    {
        int number;
        string input = Console.ReadLine()!;
        bool success = int.TryParse(input, out number);

        while (!success)
        {
            Console.WriteLine("Please, enter a number");
            input = Console.ReadLine()!;
            success = int.TryParse(input, out number);
        }

        return number;
    }
}