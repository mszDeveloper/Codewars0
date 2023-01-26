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

        //https://www.codewars.com/kata/5390bac347d09b7da40006f6
        public static class JadenCase
        {
            public static string ToJadenCase(string phrase)
            {
                char[] result = phrase.ToCharArray();
                result[0] = char.ToUpper(result[0]);
                for (int i = 0; i < result.Length - 1; i++)
                {
                    if (result[i] == ' ')
                    {
                        result[i + 1] = char.ToUpper(result[i + 1]);
                    }
                }
                return new string(result);
            }
            //public static string ToJadenCase(this string phrase)
            //{
            //    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
            //}
        }

        //https://www.codewars.com/kata/555eded1ad94b00403000071
        public class NthSeries
        {
            public static string seriesSum(int n)
            {
                double sum = 0;
                int denominator = 1;
                int counter = 1;
                while (counter <= n)
                {
                    sum += 1.0 / denominator;
                    denominator += 3;
                    counter++;
                }
                return sum.ToString("F", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        public static int[] Maps(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= 2;
            }
            return x;
        }
        //https://www.codewars.com/kata/5839edaa6754d6fec10000a2
        public static char FindMissingLetter(char[] array)
        {
            char[] abet = new char[]
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };
            int first = 0;
            for (int i = 0; i < abet.Length; i++)
            {
                if (abet[i] == char.ToLower(array[0]))
                {
                    first = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (char.ToLower(array[i]) != abet[i + first])
                {
                    if (char.IsUpper(array[0]))
                    {
                        return char.ToUpper(abet[i + first]);
                    }
                    else return abet[i + first];
                }
            }
            return ' ';

            //public static char FindMissingLetter(char[] array)
            //{
            //    for (int i = 0; i < array.Length - 1; i++)
            //    {
            //        if (array[i + 1] - array[i] > 1)
            //        {
            //            return (char)(array[i] + 1);
            //        }
            //    }

            //    return ' ';
            //}
        }















    }
}
