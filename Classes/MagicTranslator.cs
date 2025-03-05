namespace FizzBuzzBang.Classes;


public class MagicTranslator
{
    //SIMPLE CONSTRUCTOR
    public MagicTranslator()
    {
        //
    }

    //Class should not require a number to create an instantiation
    //public string NumberFromUser { get; set; }

    //FOR SIMPLIFICATION: there is no longer a separate variable for the user number as an integer
    //public int UserNumberAsInt{get; set;} 


    //Default constructor - non-functional? Try for printing to console

    //SIMILAR TO THE ABOVE: FOR SIMPLIFICATION: there is no longer a separate variable for the user number as an integer
    /*  
     public MagicTranslator() 
     {
         NumberFromUser = "0";
         UserNumberAsInt = 0;
     }
 */
    //Removal of separate variable for the number entered as an integer
    /*
     public MagicTranslator(int numberToTranslate)
     {
         NumberFromUser = numberToTranslate.ToString();

     }
    */

    /* Deleting the need constructors to require a number
     
    // Unneeded constructor
    public void UpdateNumberFromUser (string numberToTranslate)
    {
        NumberFromUser = numberToTranslate;
        UserNumberAsInt = int.Parse(numberToTranslate);
    }
    */


    //Unneeded constructor - Constructor that requires argument
    /*
    public MagicTranslator (string numberToTranslate)
    {
        NumberFromUser = numberToTranslate;
        UserNumberAsInt = int.Parse(numberToTranslate);
    }
    */

    public string TranslateNumber(string numberToTranslate)
    {
        string numberTranslated = "";
        int numberAsInt = int.Parse(numberToTranslate); //Only converting number into integer here because it is needed within the method.

        foreach (var digitToCheck in FunPhrases)
        {
            switch (DoesContainDigit(numberToTranslate, digitToCheck.Key) || numberAsInt % int.Parse(digitToCheck.Key) == 0)
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
        //For each digit in number, check for the digitToCheck from Dictionary

        for (int i = 0; i < numberFromUser.Length; i++)
        {
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