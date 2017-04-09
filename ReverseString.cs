using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class ReverseStringClass
    {
        public static string ReverseString(string s)
        {

            string newString = "";

            for (int counter = s.Length - 1; counter >= 0; counter--)
            {
                newString += s.ElementAt(counter);
            }

            return newString;
        }

        public static string ReverseString2(string s)
        {
            int length = s.Length;

            if (length <= 1)
            {
                return s;
            }

            string leftStr = s.Substring(0, length / 2);
            string rightStr = s.Substring(length / 2, length - length / 2);

            return ReverseString2(rightStr) + ReverseString2(leftStr);
        }
    }
}
