using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata11
    {
        //https://www.codewars.com/kata/530045e3c7c0f4d3420001af
        public static ulong LookSay(ulong number)
        {
            List<int> digits = new();
            digits.Add((int)(number % 10));
            number /= 10;
            while (number > 0)
            {
                int digit = (int)(number % 10);
                digits.Insert(0, digit);
                number /= 10;
            }
            StringBuilder result = new();
            int count = 0;
            int dig = digits[0];
            foreach (var item in digits)
            {
                if (dig != item)
                {
                    result.Append(count).Append(dig);
                    dig = item;
                    count = 0;
                }
                count++;
            }
            result.Append(count).Append(dig);
            return Convert.ToUInt64(result.ToString());

            //public static ulong LookSay(ulong number)
            //{
            //    var s = number.ToString();
            //    var res = "";
            //    for (int i = 0, j = 0; i < s.Length; i = j, j = i + 1)
            //    {
            //        while (j < s.Length && s[i] == s[j]) j++;
            //        res += (j - i).ToString() + s[i];
            //    }
            //    return ulong.Parse(res);
            //}

        }

        //https://www.codewars.com/kata/513e08acc600c94f01000001
        public static string Rgb(int r, int g, int b)
        {
            r = Math.Clamp(r, 0, 255);
            g = Math.Clamp(g, 0, 255);
            b = Math.Clamp(b, 0, 255);

            string result;



            return null;
        }

    }
}
