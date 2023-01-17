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
                if (s.Length <= 2) return s;
                long period = -1;
                List<string> results = new();
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
                    if (n == i) return result;
                    if (result == s)
                    {
                        period = i;
                        break;
                    }
                    results.Add(result);
                }
                if (period == -1) return "";
                int limit = (int)(n % period);
                if (limit == 0) return s;
                return results[limit - 1];
            }

        }

        //https://www.codewars.com/kata/566efcfbf521a3cfd2000056
        public class FlipNumberClass
        {
            public static string FlipNumber(string n)
            {
                StringBuilder str = new(n);
                for (int i = 0; i < n.Length - 1; i++)
                {
                    ReverseString(ref str, i);
                }
                return str.ToString();
            }
            static void ReverseString(ref StringBuilder str, int startIndex)
            {
                int limit = (str.Length - startIndex) / 2 + startIndex;
                for (int firstIndex = startIndex; firstIndex < limit; firstIndex++)
                {
                    char tmpChar = str[firstIndex];
                    int secondIndex = str.Length - 1 - firstIndex + startIndex;
                    str[firstIndex] = str[secondIndex];
                    str[secondIndex] = tmpChar;
                }
            }
            public static string FlipNumber1(string s)
            {
                if (string.IsNullOrEmpty(s))
                {
                    return s;
                }

                var sb = new StringBuilder(s.Length);

                int i = 0, j = s.Length - 1;

                for (; i < j; ++i, --j)
                {
                    sb.Append(s[j]).Append(s[i]);
                }

                if (i == j)
                {
                    sb.Append(s[i]);
                }

                return sb.ToString();
            }
            public static string FlipNumber2(string n)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < n.Length; i++)
                    sb.Append(i % 2 == 0 ? n[n.Length - (int)(i / 2) - 1] : n[(int)(i / 2)]);
                return sb.ToString();
            }
            public static string FlipNumber3(string n)
            {
                string s = "";
                for (int i = n.Length - 1; i >= n.Length / 2; i--)
                {
                    s += n[i];
                    if (i != n.Length - 1 - i)
                        s += n[n.Length - 1 - i];
                }
                return s;
            }
        }

        //https://www.codewars.com/kata/5ae64f28d2ee274164000118
        public class JomoPipi1
        {
            public static string StringFunc(string s, long x)
            {
                StringBuilder str = new(s);
                for (int i = 0; i < x; i++)
                {
                    str = FlipStr(ref str);
                }
                return str.ToString();
            }
            static StringBuilder FlipStr(ref StringBuilder str)
            {
                StringBuilder newStr = new(str.Length);
                int i = 0, j = str.Length - 1;
                while (i < j)
                {
                    newStr.Append(str[j]).Append(str[i]);
                    i++; j--;
                }
                if (i == j) newStr.Append(str[i]);
                return newStr;
            }
        }

        //https://www.codewars.com/kata/526571aae218b8ee490006f4














    }
}
