namespace FizzBuzzBang.Classes;


public class MagicTrickClass
{
    public string NumberFromUser { get; set; }

    public string FunPhrase { get; set; }

    public void MagicTrick(string numberFromUser, string funPhrase)
    {
        NumberFromUser = numberFromUser;
        FunPhrase = funPhrase;
        int UserNumberAsInt = int.Parse(numberFromUser);
    }

    //This would require the user's number and the number to be searched for
    //Figure out how to replace the variables with the parameters from the class instantiation
    public bool DoesContainDigit(string numberFromUser, int digitToCheck)
    {
        for (int i = 0; i < numberFromUser.Length; i++)
        {
            if (numberFromUser[i] == digitToCheck)
            {
                return true;
            }
        }
        return false;
    }

    //Turn into switch statements
    //Replace numbers with dictionary options
    //Replace "IsDisible" method with a simple % check within the case statement
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

        if (numberTranslated == "")
        {
            numberTranslated = numberFromUser;
        }

        return numberTranslated;
    }

    //This will become part of the switch statement
    public static bool IsDivisibleByNumber(int userNumberConverted, int numberToTest)
    {
        if (userNumberConverted % numberToTest == 0)
        {
            return true;
        }
        return false;
    }
}
/*
     public static bool IsDivisibleByNumber(int userNumberConverted, int numberToTest)
    {
        if (userNumberConverted % numberToTest == 0)
        {
            return true;
        }
        return false;
    }
 * *\

    /*
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
     */

//Method to check division
//Method to check for digit

/*
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

    if (numberTranslated == "")
    {
        numberTranslated = numberFromUser;
    }

    return numberTranslated;
}
*/

