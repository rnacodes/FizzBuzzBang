using FizzBuzzBang.Classes;
using static FizzBuzzBang.Classes.DialogOptions;
using FizzBuzzBang.Extensions;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace FizzBuzzBang;


public class Program
{
    static void Main()

    //Three dialogue options:
    //1. Translate user number into FizzBuzzBang language
    //2. Print number 1 through 1000 in FizzBuzz
    //3. Allow user to add their own special number and phrase
    {
            string numberInFBB;         

            string userActionResponse = "";

            Console.WriteLine("Let's play a game! Choose from one of the following options:");

            Console.WriteLine("Translate a number 1 - 1000 into our special FizzBuzzBang Language! (Translate)");
            Console.WriteLine("Print from 1 to 1000 in FBB (Print)");
            Console.WriteLine("Add your own number and phrase (Add)");

            //THIS IS HOW COPILOT SUGGESTED CHECKING FOR VALID INPUT
            userActionResponse = Console.ReadLine() ?? string.Empty;

            if (userActionResponse.IsOptionValid(MenuOptions))
            {
                MenuOptions[userActionResponse].Invoke();
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

        /* ////THIS IS HOW I SET UP GUARDRAILS FOR MENU INPUT
            while (!IsOptionValid(userActionResponse, MenuOptions))
            {
                Console.WriteLine("Please enter a valid response.");

                userActionResponse = Console.ReadLine().ToLower();
            }
        */

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
                Translate();
                break;

                case "print":
                Print();
                break;

                case "add":
                Add();
                break;
            };   
        }
    }
