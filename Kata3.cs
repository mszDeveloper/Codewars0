using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata3
    {

        class NextPalindrom
        {
            //https://www.codewars.com/kata/56a6ce697c05fb4667000029/train/csharp
            static string Reverse(string str)
            {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            public static int NextPal(int val)
            {
                while (true)
                {
                    val++;
                    string valStr = val.ToString();
                    if (valStr.Equals(Reverse(valStr)))
                    {
                        return val;
                    }
                }
            }
            //12
            //123
            //121
            //1234
            //12345        
            /**
             *   
             *  public static int NextPal(int val) {
                for (int i = val + 1; i < int.MaxValue; i++) {
                  var digits = i.ToString().ToCharArray();
                  Array.Reverse(digits);
                  if (i.ToString() == new string(digits)) return i;
                }
             */
        }

        //https://www.codewars.com/kata/631082840289bf000e95a334
        public static long MaxIntChain(long n)
        {
            if (n < 5)
            {
                return -1;
            }
            long d = n / 2 + 1;
            long c;
            if ((n % 2).Equals(0))
            {
                c = d - 2;
            }
            else
            {
                c = d - 1;
            }
            return c * d;
            /*
             *   public static long MaxIntChain(long n)
                  {
                    if (n < 5) return -1;
                    return (n - 1) / 2 * (n / 2 + 1);
                  }
             */
        }

        //https://www.codewars.com/kata/546e2562b03326a88e000020
        public static int SquareDigits(int n)
        {
            string numberStr = n.ToString();
            StringBuilder resultStr = new();
            foreach (var item in numberStr)
            {
                int digit = int.Parse(item.ToString());
                int digitPow = (int)Math.Pow(digit, 2);
                resultStr.Append(digitPow.ToString());
            }
            return int.Parse(resultStr.ToString());
        }

        //https://www.codewars.com/kata/62c93765cef6f10030dfa92b
        public static int Cats(int start, int finish)
        {
            int mews = 0;
            while (true)
            {
                if (finish == start)
                {
                    return mews;
                }
                if ((finish - start) == 1)
                {
                    mews++;
                    return mews;
                }
                if ((finish - start) == 2)
                {
                    mews += 2;
                    return mews;
                }
                start += 3;
                mews++;
            }
        }
        //public static int Cats3(int start, int finish)
        //{
        //    var diff = finish - start;
        //    return diff / 3 + diff % 3;
        //}

        //https://www.codewars.com/kata/54ba84be607a92aa900000f1
        public static bool IsIsogram(string str)
        {
            if (str.Length == 0) return true;
            if (str.Length == 1) return false;
            foreach (var item in str)
            {
                if (!char.IsLetter(item)) return false;
            }
            str = str.ToLower();
            char[] chars = str.ToArray();
            Array.Sort(chars);
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i - 1] == chars[i])
                {
                    return false;
                }
            }
            return true;
        }

        //https://www.codewars.com/kata/563cf89eb4747c5fb100001b
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return numbers;
            }
            int min = numbers.Min();
            int index = numbers.IndexOf(min);
            List<int> result = new(numbers);
            result.RemoveAt(index);
            return result;
        }

        public class OddDigPrime
        {
            //https://www.codewars.com/kata/55e0a2af50adf50699000126
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
            static bool IsPoorePrime(long number)
            {
                if (!IsPrime(number)) return false;
                string strNumber = number.ToString();
                foreach (var item in strNumber)
                {
                    int digit = int.Parse(item.ToString());
                    if (digit % 2 == 0) return false;
                }
                return true;
            }
            public static long[] OnlyOddDigPrimes(long n)
            {
                long poorePrimeCount = 0;
                long smaller = 3;
                for (long i = 3; i < n; i++)
                {
                    if (IsPoorePrime(i))
                    {
                        poorePrimeCount++;
                        smaller = i;
                    }
                }
                if (IsPoorePrime(n)) poorePrimeCount++;
                long bigger = n;
                while (true)
                {
                    bigger++;
                    if (IsPoorePrime(bigger)) break;
                }
                long[] result = new long[3];
                result[0] = poorePrimeCount;
                result[1] = smaller;
                result[2] = bigger;
                return result;
            }
        }


    }
}
