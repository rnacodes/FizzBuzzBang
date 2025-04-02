using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBang.Classes
{
    public static class SampleClass
    {
        public static string SampleMethod(this int number)
        {
            return (number % 3).ToString();
        }
    }
}
