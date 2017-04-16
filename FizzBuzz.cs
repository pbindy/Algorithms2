using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms 
{
    class FizzBuzzClass
    {
        public static IList<string> FizzBuzz(int n)
        {
            IList<string> myList = new List<string>();

            for (int counter = 1; counter <= n; counter++)
            {
                string nInString = "";

                if (counter % 3 == 0 )
                {
                    nInString = "Fizz";         
                }

                if (counter%5 == 0)
                {
                    nInString += "Buzz";
                }

                if (nInString == "")
                nInString = counter.ToString();

                myList.Add(nInString);
            }

            return myList;
        }

        public static IList<string> FizzBuzz2(int n)
        {
            IList<string> myList = new List<string>();

            for (int counter = 1, fizz = 0, buzz = 0 ; counter <= n; counter++)
            {
                fizz++;
                buzz++;

                if (fizz == 3 && buzz == 5)
                {
                    myList.Add("FizzBuzz");
                    fizz = 0;
                    buzz = 0;
                }

                else if (fizz == 3)
                {
                    myList.Add("Fizz");
                    fizz = 0;
                }

                else if (buzz == 5)
                {
                    myList.Add("Buzz");
                    buzz = 0;
                }

                else myList.Add(counter.ToString());
            }

            return myList;
        }
    }
}
