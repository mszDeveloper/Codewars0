using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata2
    {
        public static int TrailingZeros(int n)
        {
            //https://www.youtube.com/watch?v=9GhiTWjhB60
            //https://brilliant.org/wiki/trailing-number-of-zeros/
            int count = 0;
            int multiplier = 5;
            while (true)
            {
                int currentCoutn = n / multiplier;
                if (currentCoutn.Equals(0))
                {
                    break;
                }
                count += currentCoutn;
                multiplier *= 5;
            }
            return count;
            /*
             *   public static int TrailingZeros(int n)
                  { 
                    int fives = 0;
                    for (int i = 5; i <= n; i *= 5)
                        fives += n/i;
    
                    return fives;
                  }
             */
        }

        public static string sumStrings(string a, string b)
        {
            int minLength, maxLength;
            StringBuilder minString, maxString;
            if (a.Length >= b.Length)
            {
                minLength = b.Length;
                maxLength = a.Length;
                minString = new StringBuilder(b);
                maxString = new StringBuilder(a);
            }
            else
            {
                minLength = a.Length;
                maxLength = b.Length;
                minString = new StringBuilder(a);
                maxString = new StringBuilder(b);
            }

            int zerosCount = maxLength - minLength;
            if (zerosCount > 0)
            {
                StringBuilder zeros = new();
                for (int i = 0; i < zerosCount; i++)
                {
                    zeros.Append('0');
                }
                minString = zeros.Append(minString);
            }

            int add = 0;
            StringBuilder result = new();
            for (int index = maxLength - 1; index >= 0; index--)
            {
                int digitsSum = Convert.ToInt32(maxString[index]) + Convert.ToInt32(minString[index]) + add;
                if (digitsSum > 9)
                {
                    add = 1;
                    digitsSum %= 10;
                }
                else
                {
                    add = 0;
                }
                result.Append(digitsSum);
            }

            return result.ToString().ToCharArray().Reverse().ToString();
        }







































    }
}
