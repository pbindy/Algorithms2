using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse String
            //Console.Write("Enter a string:");
            //string myString = Console.ReadLine();

            ////string reverseString = ReverseStringClass.ReverseString(myString);
            //string reverseString = ReverseStringClass.ReverseString2(myString);

            //Console.WriteLine("The reversed string is: " + reverseString);

            //Console.ReadLine();

            //End Reverse String

            //FindMaxConsecutiveOnes

            //Console.WriteLine("Max consecutive ones: " + MaxConsecutiveOnes.FindMaxConsecutiveOnes(new int[] {0, 1, 1, 0, 1, 1, 1, 1}));
            //Console.WriteLine("Max consecutive ones: " + MaxConsecutiveOnes.FindMaxConsecutiveOnes(new int[] {0,1}));

            //End FindMaxConsecutiveOnes

            //HammingDistance

            //int x = 1;
            //int y = 4;

            //Console.WriteLine("Hamming distance of {0} and {1}: {2}", x, y, HammingDistance.FindHammingDistance(x,y));

            //End HammingDistance

            //FindComplement

            //int x = 5;

            //Console.WriteLine("NumberComplement of {0} : {1}", x, NumberComplement.FindComplement(x));

            //End FindComplement

            //Find Words

            //string[] input = new string[] {"Hello", "Alaska", "Dad", "Peace"};
            //string[] input = new string[] { "a", "b"};


            //string[] output =  KeyboardRow.FindWords(input);

            //foreach (string word in output)
            //{
            //    Console.WriteLine(word);
            //}

            //End Words

            //FizzBuzz

            //string[] input = new string[] {"Hello", "Alaska", "Dad", "Peace"};
            //string[] input = new string[] { "a", "b"};

            //int n = 15;

            //IList<string> list = FizzBuzzClass.FizzBuzz(n);
            //IList<string> list = FizzBuzzClass.FizzBuzz2(n);

            //foreach (string current in list)
            //{
            //    Console.WriteLine(current);
            //}

            //End FizzBuzz

            //Two Sum
            //int[] input = new int[] {2,5,7,9,4};
            //int[] input = new int[] { 3,5,3};
            //int target = 6;

            //int[] outputs = TwoSumClass.TwoSum2(input, target);

            //foreach (int indice in outputs)
            //{
            //    Console.WriteLine(indice);
            //}

            //End Two Sum

            //Unique String

            //bool isUnique = UniqueString.UniqueStringFunctionBookSolution("HELLO BABY");

            //End Unique String

            //Permutation String

            //bool isPermutation = StringPermutationClass.StringPermutation("HABC", "BCaH");

            //Console.WriteLine(isPermutation);
            //End Permutation String

            ////Compressed String
            //int counter = 0;
            //while (counter < 5)
            //{
            //    Console.WriteLine("Enter Original string:");

            //    string s = Console.ReadLine();

            //    string compressedString = StringCompressionClass.StringCompression(s);

            //    Console.WriteLine("Compressed string:" + compressedString);
            //    Console.WriteLine();
            //   counter++;
            //}
            ////End Compressed String

            ////Reverse Words in String
            //Console.Write("Enter a string:");
            //string myString = Console.ReadLine();

            ////string reverseString = ReverseStringClass.ReverseString(myString);
            //string reverseString = ReverseWordsInStringClass.ReverseWordsInString(myString);

            //Console.WriteLine("The reversed string is: " + reverseString);

            //Console.ReadLine();

            ////End Reverse Words in String

            //Student Attendance Record
            Console.Write("Enter the attendance:");
            string myString = Console.ReadLine();

            bool result = StudentAttendanceRecord.CheckRecord(myString);

            Console.WriteLine("result {0}:{1} ", myString, result);

            Console.ReadLine();

            //End Student Attendance Record

            Console.ReadLine();

        }
    }
}
