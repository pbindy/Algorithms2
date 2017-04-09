using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class NumberComplement
    {
        public static int FindComplement(int num)
        {
            //Convert to base 2
            char[] numBase2String = Convert.ToString(num, 2).ToCharArray();
            string newNumBase2String = string.Empty;

            for (int counter = 0; counter < numBase2String.Length; counter++)
            {
                newNumBase2String += numBase2String[counter] == '0' ? '1' : '0';
            }

            int result = Convert.ToInt32(newNumBase2String, 2);

            return result;
        }
    }
}
