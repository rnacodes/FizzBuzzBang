namespace FizzBuzzBang.Classes;

/*
public class xMagicTranslator
{
    public string NumberFromUser { get; set; }

    public int UserNumberAsInt{get; set;}

    
    //Default constructor - non-functional? Try for printing to console
    
    public MagicTranslator() 
    {
        NumberFromUser = "0";
        UserNumberAsInt = 0;
    }

    public MagicTranslator(int numberFromUser)
    {
        NumberFromUser = numberFromUser.ToString();
        
    }

    public void UpdateNumberFromUser (string numberFromUser)
    {
        NumberFromUser = numberFromUser;
        UserNumberAsInt = int.Parse(numberFromUser);
    }
    


    //Constructor that requires argument
    public MagicTranslator (string numberFromUser)
    {
        NumberFromUser = numberFromUser;
        UserNumberAsInt = int.Parse(numberFromUser);
    }

    public string TranslateNumber(string numberFromUser)
    {
        string numberTranslated = "";

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

    public static bool DoesContainDigit(string numberFromUser, string digitToCheck)//Accept key
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


    public Dictionary<string, string> FunPhrases = new Dictionary<string, string>()
        {
            {"3","Fizz"},
            {"5","Buzz" },
            {"7","Bang"}//,
            //{"9","Clink"} 
        };
}

*/