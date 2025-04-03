using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBang.Classes
{
    public static class DialogOptions
    {
        public static void Translate()
        {
            string userInputToTranslate = "";
            
            Console.WriteLine("Enter a number between 1 and 1000 to translate into our special FizzBuzzBang language!");

            userInputToTranslate = Console.ReadLine() ?? string.Empty;

            while (!userInputToTranslate.IsInputValidNumber())
            {
                Console.WriteLine("Please enter a valid number.");
                userInputToTranslate = Console.ReadLine() ?? string.Empty;
            }

            var numberInFBB = userInputToTranslate.TranslateNumber();

            Console.WriteLine(userInputToTranslate + " translated is: " + numberInFBB);
        }

        public static void Print()
        {
            Console.WriteLine("Now printing requested numbers:");

            for (int counter = 1; counter <= 100; counter++)
            {
                string numberToPrint = counter.ToString().TranslateNumber();

                Console.WriteLine(numberToPrint);

                numberToPrint = "";
            }
            
        }

        public static void Add()
        {
            Console.WriteLine("Coming soon!");
            //Console.WriteLine("Enter your special number between 1 and 9 (excl. 3, 5, and 7");
        }

        public static bool IsOptionValid(this string input, Dictionary<string, Action> options)
        {
            foreach (var option in options)
            {
                if (options.ContainsKey(input))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsInputValidNumber(this string input)
        {
            return int.TryParse(input, out int number);
        }

        public static Dictionary<string, Action> MenuOptions = new Dictionary<string, Action>()
            {
                {"translate", Translate},
                {"print", Print},
                {"add", Add}
            };
    }
}
