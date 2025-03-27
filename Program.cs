using FizzBuzzBang.Classes;
using FizzBuzzBang.Extensions;
namespace FizzBuzzBang;


internal class Program
{
    static void Main()

    //Three dialogue options:
    //1. Translate user number into FizzBuzzBang language
    //2. Print number 1 through 1000 in FizzBuzz
    //3. Allow user to add their own special number and phrase
    {
            string numberInFBB;

            string numberToTranslate;

            string userActionResponse = "";

            Console.WriteLine("Let's play a game! Choose from one of the following options:");

            Console.WriteLine("Translate a number 1 - 1000 into our special FizzBuzzBang Language! (Translate) \nPrint from 1 to 1000 in FBB (Print) \nAdd your own number and phrase (Add)");
     

            while (userActionResponse != "translate" && userActionResponse != "print" && userActionResponse != "add" || userActionResponse == null)
            {
                Console.WriteLine("Please enter a valid response.");

                userActionResponse = Console.ReadLine().ToLower();
            }

        /* THIS WAS MADE DURING MEETING
        int number = 0;
        if (int.TryParse(userActionResponse, out number))
        {
            Console.WriteLine(number.SampleMethod());
            userActionResponse = Console.ReadLine().ToLower();
        }
        */

        switch (userActionResponse)
            {
                case "translate":
                    
                Console.WriteLine("Enter a number between 1 and 1000 to translate into our special FizzBuzzBang language!");

                    numberToTranslate = Console.ReadLine();

                while(!numberToTranslate.IsInputValidNumber())
                {
                    Console.WriteLine("Please enter a valid number.");
                    numberToTranslate = Console.ReadLine();
                }
   
                    numberInFBB = numberToTranslate.TranslateNumber();

                    Console.WriteLine(numberToTranslate + " translated is: " + numberInFBB);
                    
                break;

                case "print":
                    
                Console.WriteLine("Now printing requested numbers:");

                    for (int counter = 1; counter <= 100; counter++)
                    {
                        string numberToPrint = counter.ToString().TranslateNumber();

                        Console.WriteLine(numberToPrint);

                        numberToPrint = "";
                    }
                    break;

                case "add":
                    Console.WriteLine("Coming soon!");
                    //Console.WriteLine("Enter your special number between 1 and 9 (excl. 3, 5, and 7");
                    break;
            };   
        }
    }
