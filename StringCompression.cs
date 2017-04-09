using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //Implement a method to perform basic string compression using the counts of repeated characters.
    //For example, the string aabcccccaaa would become a2b1c5a3. If the "compressed" string would not become smaller than the original
    //string, your method should return the original string.
    public static class StringCompressionClass
    {
        public static string StringCompression(string s)
        {
            //1st, test if the compressed string will be longer than the string, if yes, just return the string
            int size = CountCompression(s);

            if (size <= 0 || size >= s.Length)
            {
                return s;
            }

            var stringBuilder = new StringBuilder(); //faster than string concatenation
            int charConsecutives = 1;
            char lastChar = s[0];

            for (int counter = 1; counter < s.Length; counter++)
            {
                //same character, +1
                if (lastChar == s[counter])
                {
                    charConsecutives++;
                }
                else
                {
                    stringBuilder.Append(lastChar);
                    stringBuilder.Append(charConsecutives);
                    lastChar = s[counter];
                    charConsecutives = 1;
                }
            }
            //add the last character + nomber of consecutives
            stringBuilder.Append(lastChar);
            stringBuilder.Append(charConsecutives);

            return stringBuilder.ToString();
        }

        private static int CountCompression(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return 0;
            }

            char lastChar = s[0];
            int consecutives = 1;
            int sizeCompressedString = 0;

            for (int counter = 1; counter < s.Length; counter++)
            {
                if (s[counter] == lastChar)
                {
                    consecutives++;
                }

                else
                {
                    sizeCompressedString += 1; //character
                    sizeCompressedString += consecutives.ToString().Length;

                    lastChar = s[counter];
                    consecutives = 1;
                }
            }

            sizeCompressedString += 1; //character
            sizeCompressedString += consecutives.ToString().Length;

            return sizeCompressedString;
        }

      }
}
