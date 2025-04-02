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

        }
        public static void Print()
        {

        }

        public static void Add()
        {

        }
        
        public static bool IsOptionValid(this string input, Dictionary<string, Action> options)
        {
            foreach(var option in options)
            {
                if (options.ContainsKey(input))
                {
                    return true;
                }
            }
            return false;
        }

        public static Dictionary<string, Action> MenuOptions = new Dictionary<string, Action>()
        {
            {"translate", Translate},
            {"print", Print},
            {"add", Add}
        };
    }
}
