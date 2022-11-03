using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Codewars0
{
    class Kata1
    {
        public static string Likes(string[] name)
        {
            string displayText = String.Empty;
            string oneLikeText = " likes this";
            string likeText = " like this";
            string noOneLikesText = "no one" + oneLikeText;
            int othersNamesCount = 4;
            if (name.Length.Equals(0))
            {
                displayText = noOneLikesText;
            }
            if (name.Length.Equals(1))
            {
                displayText = name.First() + oneLikeText;
            }
            if (name.Length.Equals(2))
            {
                displayText = name.First() + " and " + name.Last() + likeText;
            }
            if (name.Length.Equals(3))
            {
                displayText = name.First() + ", " + name[1] + " and " + name.Last() + likeText;
            }
            if (name.Length >= othersNamesCount)
            {
                displayText = name.First() + ", " + name[1] + " and " + (name.Length - 2).ToString() + " others" + likeText;
            }
            return displayText;
        }

        public static int MaxSequence(int[] arr)
        {
            int maxSum = 0;
            int currentSum = 0;
            foreach (var item in arr)
            {
                currentSum += item;
                currentSum = Math.Max(currentSum, 0);
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;
        }

        public class DigPow
        {
            public static long digPow(int n, int p)
            {
                string digits = n.ToString();
                double sum = 0;
                int add = 0;
                foreach (var item in digits)
                {
                    double digit = Char.GetNumericValue(item);
                    sum += Math.Pow(digit, p + add);
                    add++;
                }
                if (!(sum % n).Equals(0)) return -1;
                return Convert.ToInt64(sum / n);
            }
        }

        public class SumDigPower
        {

            public static long[] SumDigPow(long a, long b)
            {
                List<long> numbers = new();
                for (var number = a; number <= b; number++)
                {
                    string digits = number.ToString();
                    if (digits.Length.Equals(1))
                    {
                        numbers.Add(number);
                        continue;
                    }
                    double sum = 0;
                    double power = 1;
                    foreach (var item in digits)
                    {
                        sum += Math.Pow(Char.GetNumericValue(item), power);
                        power++;
                    }
                    if (sum.Equals(number))
                    {
                        numbers.Add(number);
                    }
                }
                return numbers.ToArray();
            }
        }

        public class StripCommentsSolution
        {
            public static string StripComments(string text, string[] commentSymbols)
            {
                string[] lines = text.Split(new[] { "\n" }, StringSplitOptions.None);
                lines = lines.Select(x => x.Split(commentSymbols, StringSplitOptions.None).First().TrimEnd()).ToArray();
                return string.Join("\n", lines);
            }
        }

        public class Matrix
        {
            public static int Determinant(int[][] matrix)
            {
                // Your code here!
                return 0;
            }
        }


















    }
}
