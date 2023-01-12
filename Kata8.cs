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

























    }
}
