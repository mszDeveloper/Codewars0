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
            if (a.Length.Equals(0) || b.Length.Equals(0))
            {
                return "0";
            }
            
            StringBuilder aMut = new(a);
            StringBuilder bMut = new(b);
            RemoveLeadingZeros(ref aMut);
            RemoveLeadingZeros(ref bMut);
            if (aMut.Length.Equals(0) || bMut.Length.Equals(0))
            {
                return "0";
            }

            int minLength, maxLength;
            StringBuilder minString, maxString;
            if (aMut.Length >= bMut.Length)
            {
                minLength = bMut.Length;
                maxLength = aMut.Length;
                minString = bMut;
                maxString = aMut;
            }
            else
            {
                minLength = aMut.Length;
                maxLength = bMut.Length;
                minString = aMut;
                maxString = bMut;
            }

            int zerosCount = maxLength - minLength;
            if (zerosCount > 0)
            {
                StringBuilder zeros = new();
                for (int i = 0; i < zerosCount; i++)
                {
                    zeros.Append('0');
                }
                zeros.Append(minString);
            }

            int add = 0;
            StringBuilder result = new();
            for (int index = maxLength - 1; index >= 0; index--)
            {
                int digitsSum = Int32.Parse(maxString[index].ToString()) + Int32.Parse(minString[index].ToString()) + add;
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
            if (add > 0)
            {
                result.Append(add);
            }
            char[] chars = result.ToString().ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        static void RemoveLeadingZeros(ref StringBuilder str)
        {
            int length = str.Length;
            for (int index = 0; ; index++)
            {
                if (index >= length) break;
                if (str[index].Equals('0'))
                {
                    str.Remove(index, 1);
                    index--;
                    length--;
                }
                else break;
            }
        }
        /*
        123
        456
        579
        */





































    }
}
