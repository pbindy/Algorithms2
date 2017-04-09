using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters.
    /// What if you cannot use additional data structures ?
    /// </summary>
    /// 
    /// The time 
    class UniqueString
    {
        /// <summary>
        /// Solution from the book
        /// The time complexity for this code is O(n).
        /// The space complexity is O(1)
        /// Alternatives:
        /// 1. Compare every character of the string to every other character of the string. This will take O(n2) time and O(1) space
        /// 2. If we are allowed to modify the input string, we could sort the string in O(n log(n)) time and then linearly check the string 
        /// for neighboring characters that are identical. Careful though: many sorthing algorithms take up extra space.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        public static bool UniqueStringFunctionBookSolution(string s)
        {
            char[] table = new char[s.Length];
            for (int counter = 0; counter < s.Length - 1; counter++)
            {
                char c = s.ToUpper().ElementAt(counter);

                if (table.Contains(c))
                {
                    return false;
                }

                table[counter] = c;
            }

            return true;
        }

        public static bool UniqueStringFunction(string s)
        {
            char[] characters = s.ToUpperInvariant().ToCharArray();
            char[] charTest = new char[characters.Length];
            for (int counter = 0; counter < characters.Length - 1; counter++)
            {
                if (charTest.Contains(characters[counter]))
                {
                    return false;
                }
                charTest[counter] = characters[counter];
            }

            return true;
        }
    }
}
