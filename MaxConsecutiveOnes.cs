using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class MaxConsecutiveOnes
    {
        //Example 1:
        //Output: 3

        //Explanation: The first two digits or the last three digits are consecutive 1s.
        //The maximum number of consecutive 1s is 3.

        //Note:

        //The input array will only contain 0 and 1.
        //The length of input array is a positive integer and will not exceed 10,000

        /// <summary>
        /// Finds the maximum consecutive ones.
        /// </summary>
        /// <param name="nums">The nums.</param>
        /// <returns></returns>
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxConsecutiveOnes = 0;
            int currentMax = 0;

            for (int counter = 0; counter < nums.Length; counter++)
            {
                if (nums[counter] == 1)
                {
                    currentMax++;

                    maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentMax);
                }
                else
                {
                    currentMax = 0;
                }
            }

            return maxConsecutiveOnes;
        }
    }
}
