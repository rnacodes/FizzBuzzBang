namespace FizzBuzzBang.Classes;


public class MagicTrickClass
{
    public string NumberFromUser { get; set; }

    public string FunPhrase { get; set; }

    public int UserNumberAsInt{get; set;}

    public string numberTranslated = "";

    public void MagicTrick(string numberFromUser, string funPhrase)
    {
        NumberFromUser = numberFromUser;
        FunPhrase = funPhrase;
        UserNumberAsInt = int.Parse(numberFromUser);
    }

    //This would require the user's number and the number to be searched for
    //Figure out how to replace the variables with the parameters from the class instantiation

    //Turn into switch statements
    //Default should be no changes to number
    //Replace numbers with dictionary options
    //Replace "IsDivisible" method with a simple % check within the case statement

    /* //Add into the conversion method
    switch(numberFromUser) {
        case:
        break;
        default:
        numberTranslatedIntoFBB = numberFromUser;
        break
}
    */

    public string TranslateNumber(string numberFromUser, string numberTranslated)
    {
        //string digitToCheck;

        foreach (var digitToCheck in FunPhrases)
        {
            switch (DoesContainDigit(numberFromUser, digitToCheck.Key) || UserNumberAsInt % int.Parse((digitToCheck.Key)) == 0)
            {
                case true:
                    numberTranslated += digitToCheck.Value;
                    break;
                default:
                    break;
            }

        }
        return numberTranslated;
    }

        /*
            switch (numberFromUser)
        {


            case DoesContainDigit(numberFromUser) || if (UserNumberAsInt % numberToTest == 0) :
                 numberTranslated += "Fizz";
                break;
            default:
                numberTranslated = numberFromUser;
                break;
        }
    }
        */


    public bool DoesContainDigit(string numberFromUser, string digitToCheck)//Accept key
    {
        //string digitToCheck;

        //For each digit in number, check for the digitToCheck from Dictionary

        for (int i = 0; i < numberFromUser.Length; i++)
        {
            //digitToCheck = numberPhrase.Key;
                if (numberFromUser[i].ToString() == digitToCheck)
                {
                    return true;
                }
            }
        return false;
    }


    public bool oldDoesContainDigit(string numberFromUser)//Accept key
    {
        string digitToCheck;

        //For each digit in number, check for the digitToCheck from Dictionary
        
        for (int i = 0; i < numberFromUser.Length; i++)
        {
            foreach (var numberPhrase in FunPhrases)
            {
                digitToCheck = numberPhrase.Key;
                if (numberFromUser[i].ToString() == digitToCheck)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public Dictionary<string, string> FunPhrases = new Dictionary<string, string>()
        {
            {"3","Fizz"},
            {"5","Buzz" },
            {"7","Bang"}
        };

    //Loop needs to go around switch
    /*
    public bool DoesContainDigit(string numberFromUser)
    {
        string digitToCheck;

        for (int i = 0; i < numberFromUser.Length; i++)
        {  
            foreach (var numberPhrase in FunPhrases)
            {
                digitToCheck = numberPhrase.Key;
                if (numberFromUser[i].ToString() == digitToCheck)
                {
                    return true;
                }
            }            
        }
        return false;
    }
    */



    /*
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
    */


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


