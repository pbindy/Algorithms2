using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class CamelCaseClass
    {
        //https://www.hackerrank.com/challenges/camelcase/problem
        //DON'T: Think too much.We just need to know how many capital letters are there plus 1

        public static int CamelCase(string s)
        {
            int upperLetters = s.Count(x => Char.IsUpper(x));

            return upperLetters + 1;
        }

        public static int CamelCase2(string s)
        {
            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                    count++;
            }
            return count;
        }
    }
}