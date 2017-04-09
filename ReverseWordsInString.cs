using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    //Given a string, you need to reverse the order of characters in each word within a sentence while still 
    //preserving whitespace and initial word order.
    //Example 1:
    //Input: "Let's take LeetCode contest"
    //Output: "s'teL ekat edoCteeL tsetnoc"
    //Note: In the string, each word is separated by single space and there will not be any extra space in the string.
    public static class ReverseWordsInStringClass
    {
        public static string ReverseWordsInString(string s)
        {
            //splits by space
            var splits = s.Split(' ');
            StringBuilder reverseString = new StringBuilder();

            for (int i = 0; i < splits.Length; i++)
            {
                char[] current = splits[i].ToCharArray();

                if (current.Length > 1)
                {
                    int k = current.Length - 1;

                    for (int j = 0; j < k; j++, k--)
                    {
                        char temp = current[j];
                        current[j] = current[k];
                        current[k] = temp;
                    }
                    //splits[i] = new string(current);
                }

                reverseString.Append(current);
                reverseString.Append(" ");
            }

            return reverseString.ToString().TrimEnd();
        }
    }
}
