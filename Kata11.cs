using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            return DecToHex(r) + DecToHex(g) + DecToHex(b);
        }
        static string DecToHex(int number)
        {
            if (number == 0) return "00";
            StringBuilder result = new();
            while (number > 0)
            {
                int digit = number % 16;
                switch (digit)
                {
                    case 10: result.Insert(0, 'A'); break;
                    case 11: result.Insert(0, 'B'); break;
                    case 12: result.Insert(0, 'C'); break;
                    case 13: result.Insert(0, 'D'); break;
                    case 14: result.Insert(0, 'E'); break;
                    case 15: result.Insert(0, 'F'); break;
                    default: result.Insert(0, digit); break;
                }
                number /= 16;
            }
            if (result.Length == 1) result.Insert(0, '0');
            return result.ToString();
            //public static string Rgb(int r, int g, int b)
            //{
            //    r = Math.Max(Math.Min(255, r), 0);
            //    g = Math.Max(Math.Min(255, g), 0);
            //    b = Math.Max(Math.Min(255, b), 0);
            //    return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
            //}
        }

        //https://www.codewars.com/kata/55f4e56315a375c1ed000159
        public class PowerSumDig
        {
            public static long PowerSumDigTerm(int n)
            {
                int count = 0;
                long i = 80;
                while (count != n)
                {
                    //Console.WriteLine(count);
                    i++;
                    //if (i == 512) Console.WriteLine(i);                    
                    int sum = SumDigits(i);
                    Console.WriteLine(sum);
                    if (sum == 1) continue;
                    int pow = 2;
                    long powRes = 0;
                    while (powRes < i)
                    {
                        powRes = (long)Math.Pow(sum, pow);
                        //if (i == 512) Console.WriteLine(powRes);
                        pow++;
                    }
                    if (powRes == i) count++;
                }
                return i;
            }
            static int SumDigits(long n)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += (int)(n % 10);
                    n /= 10;
                }
                return sum;
            }
            public static int Sums(int n)
            {
                List<string> sums = new();
                for (int i = 0; i < n; i++)
                {
                    string str = i.ToString() + " => " + SumDigits(i).ToString();
                    Console.WriteLine(str);
                    sums.Add(str);
                }
                File.WriteAllLines("Sums.txt", sums);
                return SumDigits(n);
            }
        }

        //https://www.codewars.com/kata/51edd51599a189fe7f000015
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            double sum = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                int dif = secondArray[i] - firstArray[i];
                sum += dif * dif;
            }
            return sum / firstArray.Length;
        }
        //https://www.codewars.com/kata/598f76a44f613e0e0b000026
        public static int SumOfIntegersInString(string s)
        {
            int sum = 0;
            StringBuilder number = new();
            foreach (var item in s)
            {
                if (Char.IsDigit(item)) 
                {
                    number.Append(item);
                }
                else if (number.Length != 0)
                {
                    sum += int.Parse(number.ToString());
                    number.Clear();
                }
            }
            if (number.Length != 0) sum += int.Parse(number.ToString());
            return sum;
            //public static int SumOfIntegersInString(string s)
            //{
            //    return Regex.Matches(s, "\\d+").Sum(x => int.Parse(x.Value));
            //}
        }
        //https://www.codewars.com/kata/54c27a33fb7da0db0100040e
        public static bool IsSquare(int n)
        {
            if (n < 0) return false;
            int root = (int)Math.Sqrt(n);
            return n == root * root;
            //public static bool IsSquare(int n)
            //{
            //    return Math.Abs(Math.Sqrt(n) - (int)Math.Sqrt(n)) < double.Epsilon;
            //}

            //public static bool IsSquare(int n)
            //{
            //    return Math.Sqrt(n) % 1 == 0;
            //}

            //public static bool IsSquare(int n)
            //{
            //    return Math.Sqrt(n) == (int)Math.Sqrt(n);
            //}
        }
        //https://www.codewars.com/kata/55fd2d567d94ac3bc9000064
        public static long RowSumOddNumbers(long n)
        {
            return n * n * n;
        }
        //https://www.codewars.com/kata/5a03b3f6a1c9040084001765
        public static int Angle(int n)
        {
            return (n - 2) * 180;
        }



















    }
}
