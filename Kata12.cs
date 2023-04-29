using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata12
    {
        //https://www.codewars.com/kata/592fd8f752ee71ac7e00008a
        public static string Covfefe(string tweet)
        {
            string coverage = "coverage";
            string covfefe = "covfefe";
            if (tweet.Contains(coverage))
            {
                return tweet.Replace(coverage, covfefe);
            }
            else
            {
                return tweet + " " + covfefe;
            }
        }

        //https://www.codewars.com/kata/53d32bea2f2a21f666000256
        public static List<int> Largest(int n, List<int> xs)
        {
            xs.Sort();
            List<int> result = new(n);
            for (int i = xs.Count - n; i < xs.Count; i++)
            {
                result.Add(xs[i]);
            }
            return result;
        }

        //https://www.codewars.com/kata/561c34b31dbb1b11640000de
        public class IthNondecomp
        {
            private static SortedDictionary<int, int[]> Founded = new()
            {
                {1, new int[] {0, 3} }, {2, new int[] { 1, 7 } }, {3, new int[] { 2, 11 } }
            };
            public static int IthNondecompPrime(int k)
            {
                if (Founded.ContainsKey(k)) return Founded[k][1];
                int q = Founded.Last().Key;
                int number = 0;
                int n = Founded.Last().Value[0] + 1;
                while (true)
                {
                    number = 4 * n + 3;
                    if (IsPrime(number))
                    {
                        q++;
                        Founded.Add(q, new int[] {n, number});
                        if (q == k)
                        {
                            return number;
                        }
                    }
                    n++;
                }
            }

            static bool IsPrime(long number)
            {
                if (number <= 1) return false;
                if (number == 2 || number == 3 || number == 5) return true;
                if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;
                long limit = (long)Math.Floor(Math.Sqrt(number));
                long i = 6;
                while (i <= limit)
                {
                    if (number % (i + 1) == 0 || number % (i + 5) == 0) return false;
                    i += 6;
                }
                return true;
            }


        }

        //https://www.codewars.com/kata/5a29a0898f27f2d9c9000058
        public class Solution
        {
            public static int[] solve(String s)
            {
                int[] result = new int[4];
                foreach (var item in s)
                {
                    if (Char.IsUpper(item)) result[0]++;
                    else
                    if (Char.IsLower(item)) result[1]++;
                    else
                    if (Char.IsDigit(item)) result[2]++;
                    else
                    result[3]++;
                }
                return result;
            }
        }
        //https://www.codewars.com/kata/57873ab5e55533a2890000c7
        public static class Time
        {
            public static string Correct(string timeString)
            {
                if (timeString == null) return null;
                if (timeString.Length == 0) return String.Empty;
                if (!Check(timeString)) return null;
                int seconds = Convert.ToInt32(timeString[6].ToString() + timeString[7].ToString());
                int minutes = Convert.ToInt32(timeString[3].ToString() + timeString[4].ToString());
                int hours = Convert.ToInt32(timeString[0].ToString() + timeString[1].ToString());

                int addMinutes = seconds / 60;
                seconds -= 60 * addMinutes;
                minutes += addMinutes;

                int addHours = minutes / 60;
                minutes -= 60 * addHours;
                hours += addHours;

                int addDays = hours / 24;
                hours -= 24 * addDays;

                //minute += second / 60;
                //second = second % 60;

                //hour += minute / 60;
                //minute = minute % 60;

                //hour = hour % 24;

                string secondsStr = seconds.ToString();
                if (secondsStr.Length == 1) secondsStr = "0" + secondsStr;
                string minutesStr = minutes.ToString();
                if (minutesStr.Length == 1) minutesStr = "0" + minutesStr;
                string hoursStr = hours.ToString();
                if (hoursStr.Length == 1) hoursStr = "0" + hoursStr;

                return hoursStr + ":" + minutesStr + ":" + secondsStr;

            }
            static bool Check(string s)
            {
                //00:00:00
                if (
                    s.Length != 8
                    || s[2] != ':'
                    || s[5] != ':'
                    ) return false;
                for (int i = 0; i < s.Length; i++)
                {
                    if (i == 2 || i == 5) continue;
                    if (!Char.IsDigit(s[i])) return false;
                }
                return true;
            }
        }

        //https://www.codewars.com/kata/545afd0761aa4c3055001386
        public static int[] Take(int[] arr, int n)
        {
            if (arr.Length < n)
            {
                return arr;
            }
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = arr[i];
            }
            return result;
        }














    }
}
