using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata10
    {
        //https://www.codewars.com/kata/5513795bd3fafb56c200049e
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            int k = 1;
            int index = 0;
            while (index < n)
            {
                if (k % x == 0) 
                {
                    z[index] = k;
                    index++;
                }
                k++;
            }
            return z;
            //public static int[] CountBy(int x, int n)
            //{
            //    int[] z = new int[n];
            //    for (int k = 0; k < n; k++)
            //    {
            //        z[k] = (k + 1) * x;
            //    }
            //    return z;
            //}
        }

        //https://www.codewars.com/kata/55c45be3b2079eccff00010f
        public static class OrderClass
        {
            public static string Order(string words)
            {
                if (words.Length == 0) return String.Empty;
                string[] wordsArr = words.Split(' ');
                Array.Sort(wordsArr, (word1, word2) => ReturnNumber(word1).CompareTo(ReturnNumber(word2)));
                StringBuilder result = new();
                foreach (var item in wordsArr)
                {
                    result.Append(item);
                    result.Append(" ");
                }
                result.Remove(result.Length - 1, 1);
                return result.ToString();
            }

            static int ReturnNumber(string str)
            {
                StringBuilder number = new();
                foreach (var item in str)
                {
                    if (Char.IsDigit(item)) number.Append(item);
                }
                return Convert.ToInt32(number.ToString());
            }

        }






















    }
}
