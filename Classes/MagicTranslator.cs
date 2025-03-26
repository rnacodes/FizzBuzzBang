using FizzBuzzBang.Extensions;
namespace FizzBuzzBang.Classes;


public static class MagicTranslator
{
    public static string TranslateNumber(this string numberToTranslate) //Turn into extension method
    {
        string numberTranslatedToFBB = "";
        //Switched to an if statement instead of a switch statement to make the logic easier
        //Switch statement previously caused numbers that didn't meet the criteria to be an empty string.

        foreach (var digitToCheck in FunPhrases)
        {
            if (numberToTranslate.DoesContainDigit(digitToCheck.Key) || int.Parse(numberToTranslate) % int.Parse(digitToCheck.Key) == 0) 
            {
               numberTranslatedToFBB += digitToCheck.Value;
            }

        }

        if (numberTranslatedToFBB == "")
        {
            numberTranslatedToFBB = numberToTranslate;
        }
        return numberTranslatedToFBB;
    }

    public static Dictionary<string, string> FunPhrases = new Dictionary<string, string>()
     {
        {"3","Fizz"},
        {"5","Buzz" },
        {"7","Bang"}//,
        //{"9","Clink"} 
     };
}
