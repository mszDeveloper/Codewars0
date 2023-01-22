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































    }
}
