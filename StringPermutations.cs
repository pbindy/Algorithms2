using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //checks if 2 strings are a permutation (same characters, different orders)
    public static class StringPermutationClass
    {
        //Solution 1, sort the characters and check if they are equals
        public static bool StringPermutation(string s, string s2)
        {
            if (s.Length != s2.Length)
            {
                return false;
            }
            char[] sOrdered = s.ToCharArray();
            char[] s2Ordered = s2.ToCharArray();

            Array.Sort(sOrdered);
            Array.Sort(s2Ordered);

            string newS = new string(sOrdered);
            string newS2 = new string(s2Ordered);

            return newS.Equals(newS2);
        }

      }
}
