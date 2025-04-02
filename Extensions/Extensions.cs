using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FizzBuzzBang.Extensions;

public static class Extensions
{   public static bool IsInputValidNumber(this string input)
    {
        if (int.TryParse(input, out _))
        {
            return true;
        }
        return false;
    }
    

    //THIS IS THE ORIGINAL
    /*
    public static bool IsInputValidNumber(this string input)
    {
        bool isValid = input.All(char.IsDigit);
        return isValid;
    }
    */

    /* NEEDS TO BE CORRECTED
    public static bool IsValidMenuOption (this string input)
    {
        bool isValid = (input != "translate" && input != "print" && input != "add" || input == null);
        return isValid;
    }
    */

    //Kept this as its own function for experimentation
    public static bool DoesContainDigit(this string numberFromUser, string digitToCheck)//Accept key
    {
        if (numberFromUser.Contains(digitToCheck))
        {
            return true;
        }
        return false;
    }
}
