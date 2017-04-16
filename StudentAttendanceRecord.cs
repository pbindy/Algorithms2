using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    //https://leetcode.com/contest/leetcode-weekly-contest-28/problems/student-attendance-record-i/
    //    You are given a string representing an attendance record for a student.The record only contains the following three characters:

    //'A' : Absent.
    //'L' : Late.
    //'P' : Present.
    //A student could be rewarded if his attendance record doesn't contain more than one 'A' (absent) or more than two continuous 'L' (late).

    //You need to return whether the student could be rewarded according to his attendance record.

    //Example 1:
    //Input: "PPALLP"
    //Output: True
    //Example 2:
    //Input: "PPALLL"
    //Output: False


    public static class StudentAttendanceRecord
    {
        public static bool CheckRecord(string s)
        {
            if (s.Length == 0)
            {
                return false;
            }

            char[] array = s.ToUpper().ToCharArray();

            int a = 0;
            int l = 0;

            for (int counter = 0; counter < array.Length; counter++)
            {
                l = array[counter] == 'L' ? l + 1 : 0;

                if (l > 2)
                {
                    return false;
                }

                if (array[counter] == 'A')
                {
                    a++;

                    if (a > 1)
                    {
                        return false;
                    }
                }            
            }
            return true;
        }
    }
}
