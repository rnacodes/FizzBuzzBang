namespace FizzBuzzBang;

    internal class Program
    {
    static void Main()
    {
        string numberTranslatedIntoFBB = "";

        Console.WriteLine("Let's play a game! Enter a number between 1 and 100 " +
                    "and I will translate it into our special FizzBuzzBang language!");
        
        string numberFromUser = Console.ReadLine();

        numberTranslatedIntoFBB = ProgramHelpers.TranslateNumber(numberFromUser, numberTranslatedIntoFBB);

        Console.WriteLine(numberFromUser + " translated is: " + numberTranslatedIntoFBB);
        
    }
}

