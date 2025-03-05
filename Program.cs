using FizzBuzzBang.Classes;
namespace FizzBuzzBang;

internal class Program
{
    static void Main()

    //Three dialogue options:
    //1. Translate user number into FizzBuzzBang language
    //2. Print number 1 through 1000 in FizzBuzz
    //3. Allow user to add their own special number and phrase
    {

        string numberTranslatedIntoFBB; //= "";
        string numberToTranslate; //To prevent confusion over the source of the number, the variable has been renamed.
        MagicTranslator fizzBuzzTranslator = new MagicTranslator(); //Translator is initialized without needing a number

        Console.WriteLine("Let's play a game! Choose from one of the following options:");

        Console.WriteLine("Translate a number 1 - 1000 into our special FizzBuzzBang Language! (Translate) \nPrint from 1 to 1000 in FBB (Print) \nAdd your own number (Add)");
        
        string userActionResponse = Console.ReadLine().ToLower();

        switch(userActionResponse) 
        {
            case "translate":
                Console.WriteLine("Enter a number between 1 and 1000 to translate into our special FizzBuzzBang language!");

                numberToTranslate = Console.ReadLine();

                numberTranslatedIntoFBB = fizzBuzzTranslator.TranslateNumber(numberToTranslate);

                Console.WriteLine(numberToTranslate + " translated is: " + numberTranslatedIntoFBB);

                //MagicTranslator fizzBuzzTranslator = new MagicTranslator(); //No need to instantiate translator again here

                /* //THIS WILL BE REUSED IN THE NEXT DIALOGUE OPTION
                for (int numberToTranslate. = 1; numberToTranslate <= 100; numberToTranslate++)
                {
                    fizzBuzzTranslator.UpdateNumberFromUser(numberToTranslate.ToString());
                    numberTranslatedIntoFBB = fizzBuzzTranslator.TranslateNumber(numberToTranslate.ToString());
                     //(numberToTranslate.ToString(), numberTranslatedIntoFBB);
                    Console.WriteLine(numberTranslatedIntoFBB);
                    numberTranslatedIntoFBB = "";
                }     
                */
                break;
            case "print":
                Console.WriteLine("Now printing requested numbers:");
                //Console.WriteLine("Coming soon!");
                /*
                MagicTranslator fizzyBuzzyOneThousand = new MagicTranslator(); //No need to instantiate translator again here

                for (int numberToTranslate = 1; numberToTranslate <= 1000; numberToTranslate++)
                {
                    
                    /*
                    fizzyBuzzyOneThousand.UpdateNumberFromUser(numberToTranslate.ToString());
                    numberTranslatedIntoFBB = fizzyBuzzyOneThousand.TranslateNumber(numberToTranslate.ToString());
                     //(numberToTranslate.ToString(), numberTranslatedIntoFBB);
                    Console.WriteLine(numberTranslatedIntoFBB);
                    numberTranslatedIntoFBB = "";
                }     
                */
                break;
            case "add":
                Console.WriteLine("Coming soon!");
                //Console.WriteLine("Enter your special number between 1 and 9 (excl. 3, 5, and 7");
                break;
            default:
                Console.WriteLine("Please enter a valid response.");
                break;
        };
    }
}

