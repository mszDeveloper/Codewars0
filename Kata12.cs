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



















    }
}
