namespace FizzBuzzBang;
internal class ProgramHelpers
{
    public static string TranslateNumber(string numberFromUser, string numberTranslated)
    {
        int userNumberAsInteger = int.Parse(numberFromUser);
       
        if (DoesContainDigit(numberFromUser, "3") || IsDivisibleByNumber(userNumberAsInteger, 3))
        {
            numberTranslated += "Fizz";
        }

        if (DoesContainDigit(numberFromUser, "5") || IsDivisibleByNumber(userNumberAsInteger, 5))
        {
            numberTranslated += "Buzz";
        }

        if (DoesContainDigit(numberFromUser, "7") || IsDivisibleByNumber(userNumberAsInteger, 7))
        {
            numberTranslated += "Bang";
        }

        if(numberTranslated == "")
        {
            numberTranslated = numberFromUser;
        }

        return numberTranslated;
    }

    public static bool DoesContainDigit(string numberFromUser, string digitToCheck)
    {
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