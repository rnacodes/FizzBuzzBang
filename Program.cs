﻿using FizzBuzzBang.Classes;
namespace FizzBuzzBang;

internal class Program

    //Took away Program Helpers because everything needed could go into the MagicTranslator class.
{
    static void Main()

    //Three dialogue options:
    //1. Translate user number into FizzBuzzBang language
    //2. Print number 1 through 1000 in FizzBuzz
    //3. Allow user to add their own special number and phrase
    {
        //while (true)
        //{
            string numberTranslatedIntoFBB;

            string numberToTranslate; //To prevent confusion over the source of the number, the variable has been renamed.

            MagicTranslator fizzBuzzTranslator = new MagicTranslator(); //Translator is initialized without needing a number

            // Program begins here


            Console.WriteLine("Let's play a game! Choose from one of the following options:");

            Console.WriteLine("Translate a number 1 - 1000 into our special FizzBuzzBang Language! (Translate) \nPrint from 1 to 1000 in FBB (Print) \nAdd your own number and phrase (Add)");

            //Added test for valid user input        

            //while (true)
            //{
                string userActionResponse = Console.ReadLine().ToLower();

                if (userActionResponse != "translate" && userActionResponse != "print" && userActionResponse != "add" || userActionResponse == null)
                {
                    Console.WriteLine("Please enter a valid response.");
                    //break;
                }
                    switch (userActionResponse)
                    {
                        case "translate":
                            Console.WriteLine("Enter a number between 1 and 1000 to translate into our special FizzBuzzBang language!");

                            numberToTranslate = Console.ReadLine();

                            numberTranslatedIntoFBB = fizzBuzzTranslator.TranslateNumber(numberToTranslate);

                            Console.WriteLine(numberToTranslate + " translated is: " + numberTranslatedIntoFBB);
                            break;

                        case "print":
                            Console.WriteLine("Now printing requested numbers:");

                            //No need to instantiate translator again here
                            //Before this, I had to instantiate the number to print for each number
                            //This was cumbersome and inefficient.
                            //Renamed counter to just "counter"

                            for (int counter = 1; counter <= 10; counter++)
                            {
                                string numberToPrint = fizzBuzzTranslator.TranslateNumber(counter.ToString());

                                Console.WriteLine(numberToPrint);

                                numberToPrint = "";

                                counter++;
                            }
                            break;
                        case "add":
                            Console.WriteLine("Coming soon!");
                            //Console.WriteLine("Enter your special number between 1 and 9 (excl. 3, 5, and 7");
                            break;
                    };
                
            //}
       // }
    }
}