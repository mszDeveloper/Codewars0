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



































    }
}
