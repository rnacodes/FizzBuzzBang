using FizzBuzzBang.Classes;
namespace FizzBuzzBang;

internal class Program
{
    static void Main()
    {
        string numberTranslatedIntoFBB = "";
        //MagicTranslator fizzyBuzzy = new MagicTranslator();

        Console.WriteLine("Let's play a game! Choose from one of the following options:");
        Console.WriteLine("Translate a number 1 - 100 into our special FizzBuzzBang Language! (Translate) \nPrint from 1 to 1000 in FBB (Print) \nAdd your own number (Add)");
        string userActionResponse = Console.ReadLine().ToLower();

        switch(userActionResponse) 
        {
            case "translate":
                Console.WriteLine("Enter a number between 1 and 1000 to translate into our special FizzBuzzBang language!");

                string numberFromUser = Console.ReadLine();

                MagicTranslator fizzyBuzzy = new MagicTranslator(numberFromUser);

                numberTranslatedIntoFBB = fizzyBuzzy.TranslateNumber(numberFromUser);

                Console.WriteLine(numberFromUser + " translated is: " + numberTranslatedIntoFBB);
                break;
            case "print":
                Console.WriteLine("Coming soon!");
                /*
                MagicTranslator fizzyBuzzyOneThousand = new MagicTranslator();

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
                Console.WriteLine("Enter your special number between 1 and 9 (excl. 3, 5, and 7");
                break;
            default:
                Console.WriteLine("Please enter a valid response.");
                break;
        };


        // Console.WriteLine("Let's play a game! Enter a number between 1 and 100 " +
        //"and I will translate it into our special FizzBuzzBang language!");



    }
}

