namespace FizzBuzzBang;
internal class ProgramHelpers
{
    // If DoesContainDigit is true, add the funPhrase to the numberTranslatedToFBB string
    // The combined method with steps in order should take numberFromUser and digitToCheck as arguments
    //If returns true, append funPhrase to numberTranslatedToFBB and continue to next number
    //Two variables for input number - one as string and one as number
    public string numberFromUser = "33";
    public string numberTranslatedToFBB = "";

    public static string TranslateNumber(string numberFromUser, string numberTranslated)
    {
        int userNumberConverted = int.Parse(numberFromUser);
        //if contains 3 OR is divisible by 3, add Fizz
        if (DoesContainDigit(numberFromUser, "3") || IsDivisibleByNumber(userNumberConverted, 3))
        {
            numberTranslated += "Fizz";
        }

        if (DoesContainDigit(numberFromUser, "5") || IsDivisibleByNumber(userNumberConverted, 5))
        {
            numberTranslated += "Buzz";
        }

        if (DoesContainDigit(numberFromUser, "7") || IsDivisibleByNumber(userNumberConverted, 7))
        {
            numberTranslated += "Bang";
        }

        return numberTranslated;
    }

    public static bool DoesContainDigit(string numberFromUser, string digitToCheck)
    {
        //Make sure this stops if a match is found
        for (int i = 0; i < numberFromUser.Length; i++)
        {
            if (numberFromUser[i].ToString() == digitToCheck)
            {
                return true;
            }
        }
        return false;
    }

    // Use variable of user entered number that has been converted to integer
    public static bool IsDivisibleByNumber(int userNumberConverted, int numberToTest)
    {
        if (userNumberConverted % numberToTest == 0)
        {
            return true;
        }
        return false;
    }
}

//Stuff
/*
foreach (char c in numberFromUser)
{
    if (c == digitToCheck)
    {
        return funPhrase;
    }
}
*/