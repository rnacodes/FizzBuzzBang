namespace FizzBuzzBang;

    internal class Program
    {
        static void Main()
        {
        string numberTranslated= "";
        
        Console.WriteLine("Let's play a game! Enter a number between 1 and 100 " +
                    "and I will translate it into our special FizzBuzzBang language!");
        
        string numberFromUser = Console.ReadLine();

        numberTranslated = ProgramHelpers.TranslateNumber(numberFromUser, numberTranslated);

        Console.WriteLine("Your number translated is: " + numberTranslated);
        }
    }

