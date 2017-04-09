using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class TwoSumClass
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] returnIndices = new int[] { -1, -1 };

            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = x + 1; y < nums.Length; y++)
                {
                    if (nums[x] + nums[y] == target)
                    {
                        returnIndices[0] = x;
                        returnIndices[1] = y;
                        return returnIndices;
                    }
                }
            }

            return returnIndices;
        }

        public static int[] TwoSum2(int[] nums, int target)
        {
            if (nums.Length < 2)
            {
                return nums;
            }

            var result = new int[2];

            var numsInDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int numberToFind = target - nums[i];
                if (numsInDictionary.ContainsKey(numberToFind))
                {
                    result[0] = numsInDictionary[numberToFind];
                    result[1] = i;
               
                    return result;
                }
                if (!numsInDictionary.ContainsKey(nums[i]))
                {
                    numsInDictionary.Add(nums[i], i);
                }
            }

            return result;
        }

    }
}
