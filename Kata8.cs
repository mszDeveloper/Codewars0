using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata8
    {
        //https://www.codewars.com/kata/54b42f9314d9229fd6000d9c
        public static string DuplicateEncode(string word)
        {
            string wordLower = word.ToLower();
            char[] sortedWord = wordLower.ToCharArray();
            Array.Sort(sortedWord);
            //key - letter, value - bracket
            Dictionary<char, char> dict = new();
            char letter = Char.MinValue;
            foreach (var item in sortedWord)
            {
                if (item != letter)
                {
                    dict.Add(item, '(');
                    letter = item;
                }
                else
                {
                    dict[item] = ')';
                }
            }
            StringBuilder result = new();
            foreach (var item in wordLower)
            {
                result.Append(dict[item]);
            }
            return result.ToString();
        }

        //https://www.codewars.com/kata/5596f6e9529e9ab6fb000014
        public class CalculateStringRotation
        {
            public static int ShiftedDiff(string first, string second)
            {
                if (first == second) return 0;
                if (first.ToLower() == second.ToLower()) return -1;
                if (first.Length != second.Length) return -1;

                StringBuilder firstB = new(first);
                for (int i = 1; i <= first.Length; i++)
                {
                    RotateStringForward(ref firstB);
                    if (firstB.ToString() == second) return i;
                }
                return -1;
            }
            static void RotateStringForward(ref StringBuilder str)
            {
                int length = str.Length;
                var last = str[length - 1];
                for (int i = length - 1; i > 0; i--)
                {
                    str[i] = str[i - 1];
                }
                str[0] = last;
            }

            //public static int ShiftedDiff(string first, string second)
            //{
            //    if (second.Length != first.Length)
            //        return -1;
            //    return (second + second).IndexOf(first);
            //}
        }

        //https://www.codewars.com/kata/580755730b5a77650500010c
        public static string SortMyString(string s)
        {
            StringBuilder even = new();
            StringBuilder odd = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0) even.Append(s[i]);
                else odd.Append(s[i]);
            }
            return even.ToString() + " " + odd.ToString();
        }

        //https://www.codewars.com/kata/5ae43ed6252e666a6b0000a4
        public class JomoPipi
        {
            public static string jumbledString(string s, long n)
            {
                //Console.WriteLine(s.Length);
                long period = CalcPeriod(s);
                //Console.WriteLine(period);
                long limit = n % period;
                string result = s;
                for (int i = 1; i <= limit; i++)
                {
                    string even = "";
                    string odd = "";
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (j % 2 == 0) even += result[j];
                        else odd += result[j];
                    }
                    result = even + odd;
                    //Console.WriteLine(i.ToString() + " " + result);
                   //if (result == s) Console.WriteLine("==========");
                }
                return result;
            }
            static int CalcPeriod(string s)
            {
                string result = s;
                for (int i = 1; i <= s.Length; i++)
                {
                    string even = "";
                    string odd = "";
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (j % 2 == 0) even += result[j];
                        else odd += result[j];
                    }
                    result = even + odd;
                    if (result == s) return i;
                }
                return -1;
            }

        }



















    }
}
