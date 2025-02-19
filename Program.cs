namespace FizzBuzzBang;

    internal class Program
    {
    static void Main()
    {
        string numberTranslatedIntoFBB = "";

        // Code below is for iterating through 1 to 100.
        /*
         int numberToTranslate;
        for (numberToTranslate = 1; numberToTranslate <= 100; numberToTranslate++)
        {
            numberTranslatedIntoFBB = ProgramHelpers.TranslateNumber(numberToTranslate.ToString(), numberTranslatedIntoFBB);
            Console.WriteLine(numberTranslatedIntoFBB);
            numberTranslatedIntoFBB = "";
        }
        */

        //The version below is for user input

        Console.WriteLine("Let's play a game! Enter a number between 1 and 100 " +
                    "and I will translate it into our special FizzBuzzBang language!");
        
        string numberFromUser = Console.ReadLine();

        numberTranslatedIntoFBB = ProgramHelpers.TranslateNumber(numberFromUser, numberTranslatedIntoFBB);

        Console.WriteLine(numberFromUser + " translated is: " + numberTranslatedIntoFBB);
        
    }
}

