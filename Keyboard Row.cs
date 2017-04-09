using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class KeyboardRow
    {
        //Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.
        //Example 1:
        //Input: ["Hello", "Alaska", "Dad", "Peace"]
        //Output: ["Alaska", "Dad"]
        //Note:
        //You may use one character in the keyboard more than once.
        //You may assume the input string will only contain letters of alphabet.
        public static string[] FindWords(string[] words)
        {
            char[] rowUp = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P'};
            char[] rowMiddle = {'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L'};
            char[] rowDown = { 'Z', 'X', 'C', 'V', 'B', 'N', 'M'};

            ArrayList oneRowWords = new ArrayList();
            char[] rowToUse = new char[10];

            foreach (string currentWord in words)
            {
                if (currentWord.Length == 1)
                {
                    oneRowWords.Add(currentWord);
                }
                else
                {
                    char[] currentWordChar = currentWord.ToUpper().ToCharArray();

                    //Determines which row we are based on the 1st character of the word
                    if (rowUp.Contains(currentWordChar[0]))
                    {
                        rowToUse = rowUp;
                    }
                    else if (rowMiddle.Contains(currentWordChar[0]))
                    {
                        rowToUse = rowMiddle;
                    }
                    else
                    {
                        rowToUse = rowDown;
                    }

                    int counter = 1;
                    bool isOneRow = true;

                    //test that all the letters (from index 1) are in the table row as character in position 0
                    while (counter < currentWord.Length && isOneRow)
                    {
                        if (!rowToUse.Contains(currentWordChar[counter]))
                        {
                            isOneRow = false;
                        }

                        counter++;
                    }

                    if (isOneRow)
                    {
                        oneRowWords.Add(currentWord);
                    }
                }
            }

            string[] arrayToReturn = (string[])oneRowWords.ToArray(typeof(string));

            return arrayToReturn;
        }
    }
}