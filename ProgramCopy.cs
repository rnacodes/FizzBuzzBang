using FizzBuzzBang.Classes;
using static FizzBuzzBang.Classes.DialogOptions;
using static FizzBuzzBang.Extensions.Extensions;

namespace FizzBuzzBang;


public class Program
{
    static void Main()
    {
        string userActionResponse;

        Console.WriteLine("Let's play a game! Choose from one of the following options:");
        Console.WriteLine("1. Translate a number 1 - 1000 into our special FizzBuzzBang Language! (Translate)");
        Console.WriteLine("2. Print from 1 to 1000 in FBB (Print)");
        Console.WriteLine("3. Add your own number and phrase (Add)");

        userActionResponse = Console.ReadLine() ?? string.Empty;

        while (!userActionResponse.IsOptionValid())
        {
            Console.WriteLine("Please enter a valid response.");
            userActionResponse = Console.ReadLine().ToLower();
        }

        if (Enum.TryParse(userActionResponse, true, out DialogOptions.NewMenuOptions selectedOption))
        {
            switch (selectedOption)
            {
                case DialogOptions.NewMenuOptions.Translate:
                    Translate();
                    break;
                case DialogOptions.NewMenuOptions.Print:
                    Print();
                    break;
                case DialogOptions.NewMenuOptions.Add:
                    Add();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }

    static void Translate()
    {
        // Implementation for Translate
    }

    static void Print()
    {
        // Implementation for Print
    }

    static void Add()
    {
        // Implementation for Add
    }
}
