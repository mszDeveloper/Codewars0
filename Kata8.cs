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

                int length = first.Length;
                StringBuilder firstB = new(first);
                for (int i = 1; i <= length; i++)
                {
                    RotateStringForward(ref firstB);
                    Console.WriteLine(firstB);
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























    }
}
