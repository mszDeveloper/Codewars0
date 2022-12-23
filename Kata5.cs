using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata5
    {
        //https://www.codewars.com/kata/53dbd5315a3c69eed20002dd
        public class ListFilterer
        {
            public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
            {
                List<int> result = new();
                foreach (var item in listOfItems)
                {
                    if (item is int)
                    {
                        result.Add((int)item);
                    }
                }
                return result;
                //return listOfItems.OfType<int>();
            }
        }

        //https://www.codewars.com/kata/5583090cbe83f4fd8c000051
        class Digitizer
        {
            static string Reverse(string str)
            {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            public static long[] Digitize(long n)
            {
                string numberStr = n.ToString();
                string reversStr = Reverse(numberStr);
                List<long> numberList = new();
                foreach (var item in reversStr)
                {
                    numberList.Add(int.Parse(item.ToString()));
                }
                return numberList.ToArray();
            }
        }

        //https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9
        public static int FindShort(string s)
        {
            int curCount = 0;
            int minCount = s.Length;
            foreach (var item in s)
            {
                if (item == ' ')
                {
                    if (curCount < minCount)
                    {
                        minCount = curCount;
                    }
                    curCount = 0;
                    continue;
                }
                curCount++;
            }
            if (curCount < minCount)
            {
                minCount = curCount;
            }
            return minCount;
            /*
             *   public static int FindShort(string s)
                  {
                    int shortest = int.MaxValue;
                    foreach (string word in s.Split(' ')) {
                      shortest = Math.Min(word.Length, shortest);
                    }
                    return shortest;
                  }
             */
        }

        //https://www.codewars.com/kata/58aa5d32c9eb04d90b000107
        public class KataMobius
        {
            //Делится на квадрат любого простого числа.
            static bool IsDivisibleBySquareAnyPrime(long n)
            {
                long div = 1;
                long max = (long)Math.Sqrt(n);
                while (div <= max)
                {
                    if (IsPrime(div))
                    {
                        long divSq = (long)Math.Pow(div, 2);
                        if (n % divSq == 0)
                        {
                            return true;
                        }
                    }
                    div++;
                }
                return false;
            }
            //Имеет четное количество простых множителей.
            static bool HasEvenNumberPrimeFactors(long n)
            {
                long mult = 1;
                long count = 0;
                while (mult <= n)
                {
                    if (IsPrime(mult))
                    {
                        if (n % mult == 0)
                        {
                            count++;
                            n /= mult;
                            mult = 1;
                            continue;
                        }
                    }
                    mult++;
                }
                return count % 2 == 0;
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
            public int Mobius(double n)
            {
                Console.WriteLine(n);
                long number = (long)n;
                if (IsDivisibleBySquareAnyPrime(number))
                {
                    return 0;
                }
                else if (!IsDivisibleBySquareAnyPrime(number) && HasEvenNumberPrimeFactors(number))
                {
                    return 1;
                }
                else return -1;
            }
        }

        //https://www.codewars.com/kata/523b623152af8a30c6000027
        public static double Square(double n)
        {
            return n * n;
        }

        //https://www.codewars.com/kata/57a429e253ba3381850000fb
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / Math.Pow(height, 2);
            if (bmi <= 18.5)
            {
                return "Underweight";
            }
            if (bmi <= 25.0)
            {
                return "Normal";
            }
            if (bmi <= 30.0)
            {
                return "Overweight";
            }
            if (bmi > 30.0)
            {
                return "Obese";
            }
            return "";
        }

        //https://www.codewars.com/kata/57c6b44f58da9ea6c20003da
        public static double Geo_Mean(int[] nums, double arith_mean)
        {
            double sum = 0;
            double product = 1;
            foreach (var item in nums)
            {
                sum += item;
                product *= item;
            }
            int fullLength = nums.Length + 1;
            double fullSum = arith_mean * fullLength;
            double missingNumber = fullSum - sum;
            product *= missingNumber;
            return Math.Pow(product, 1.0 / fullLength);
        }













    }
}
