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


















    }
}
