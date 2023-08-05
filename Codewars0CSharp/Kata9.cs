using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata9
    {
        //https://www.codewars.com/kata/526571aae218b8ee490006f4
        public static int CountBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n % 2;
                n /= 2;
            }
            return count;
            //public static int CountBits(int n)
            //{
            //    int result = 0;
            //    while (n > 0)
            //    {
            //        result += n & 1;
            //        n >>= 1;
            //    }
            //    return result;
            //}
        }
        //https://www.codewars.com/kata/554b4ac871d6813a03000035
        public static string HighAndLow(string numbers)
        {
            Console.WriteLine(numbers);
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            StringBuilder numberStr = new();
            foreach (var item in numbers)
            {
                if (item == ' ')
                {
                    int number = Convert.ToInt32(numberStr.ToString());
                    if (number < min) min = number;
                    if (number > max) max = number;
                    numberStr.Clear();
                    continue;
                }
                numberStr.Append(item);
            }
            int lastNumber = Convert.ToInt32(numberStr.ToString());
            if (lastNumber < min) min = lastNumber;
            if (lastNumber > max) max = lastNumber;
            return max.ToString() + " " + min.ToString();
        }

        //https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097
        public static int СenturyFromYear(int year)
        {
            int century = year / 100;
            if (year % 100 != 0) century++;
            return century;
            //    return (year - 1) / 100 + 1;
        }
        //https://www.codewars.com/kata/52fb87703c1351ebd200081f
        public static string WhatCentury(string year)
        {
            int century = (Convert.ToInt32(year) - 1) / 100 + 1;
            string centuryStr = century.ToString();
            if (century >= 4 && century <= 20) return centuryStr + "th";
            switch (centuryStr[^1])
            {
                case '1': return centuryStr + "st";
                case '2': return centuryStr + "nd";
                case '3': return centuryStr + "rd";
                default: return centuryStr + "th";
            }
        }

        //https://www.codewars.com/kata/59a8570b570190d313000037
        public static long SumCubes(int n)
        {
            //long sum = 0;
            //for (long i = 1; i <= n; i++)
            //{
            //    sum += i * i * i;
            //}
            //return sum;
            long resultSq = ((n + 1) * n / 2);
            return resultSq * resultSq;
        }

        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0) return "even";
            else return "odd";
        }
        public static string FilterNumbers(string str)
        {
            StringBuilder result = new();
            foreach (var item in str)
            {
                if (!Char.IsNumber(item)) result.Append(item);
            }
            return result.ToString();
        }
        public static string HowManyDalmatians(int n)
        {
            List<string> dogs = new()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };
            if (n <= 10) return dogs[0];
            if (n <= 50) return dogs[1];
            if (n <= 101) return dogs[3];
            return dogs[2];
        }
        public int FacCalculation(int startValue)
        {
            if (startValue < 0) return 0;
            if (startValue == 0) return 1;
            return FacRecursion(startValue);
        }
        protected int FacRecursion(int value)
        {
            if (value == 1) return 1;
            return value * FacRecursion(value - 1);
        }
        //https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            if (n < 0 || n > 12) throw new ArgumentOutOfRangeException();
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
        //https://www.codewars.com/kata/5a045fee46d843effa000070
        public class FactDecomp
        {
            public static string Decomp(int n)
            {
                StringBuilder result = new();
                for (int p = 2; p <= n; p++)
                {
                    if (IsPrime(p))
                    {
                        int power = CalcPower(n, p);
                        result.Append(p);
                        if (power != 1)
                        {
                            result.Append("^").Append(power);
                        }
                        result.Append(" * ");
                    }
                }
                result.Remove(result.Length - 3, 3);
                return result.ToString();
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
            static int CalcPower(int n, int p)
            {
                int sum = 0;
                int pow = 1;
                while (true)
                {
                    int add = (int)Math.Floor(n / Math.Pow(p, pow));
                    if (add == 0) break;
                    sum += add;
                    pow++;
                }
                return sum;
            }

        }






















    }
}
