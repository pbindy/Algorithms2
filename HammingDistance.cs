using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class HammingDistance
    {
        public static int FindHammingDistance(int x, int y)
        {
            int hammingDistance = 0;

            if (x == y)
            {
                return hammingDistance;
            }

            int biggest = Math.Max(x, y);
            int smallest = Math.Min(x, y);

            //Convert to base 2
            string biggestBinaryString = Convert.ToString(biggest, 2);
            string smallestBinaryString = Convert.ToString(smallest, 2);


            int indexDifference = biggestBinaryString.Length - smallestBinaryString.Length;

            char[] biggestBinary = biggestBinaryString.ToCharArray();
            //add the missing leading 0 if necessary
            char[] smallestBinary = smallestBinaryString.PadLeft(indexDifference + smallestBinaryString.Length, '0').ToCharArray();
        

            for (int counter = smallestBinary.Length - 1; counter >= 0; counter--)
            {
                if (smallestBinary[counter] != biggestBinary[counter])
                {
                    hammingDistance++;
                }
            }

            return hammingDistance;
        }
    }
}
