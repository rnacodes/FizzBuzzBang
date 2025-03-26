using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FizzBuzzBang.Extensions;

public static class Extensions
{
    public static bool IsInputValid(this string input)
    {
        //This method will be an extension method for whether user input contains a valid menu option
        return true;
    }

    //Kept this as its own function instead of adding to the above to make the above code more readable
    public static bool DoesContainDigit(this string numberFromUser, string digitToCheck)//Accept key
    {
        if (numberFromUser.Contains(digitToCheck))
        {
            return true;
        }
        return false;
    }
}
