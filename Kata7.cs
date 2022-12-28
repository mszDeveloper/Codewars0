using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata7
    {
        //https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec
        public class Persist
        {
            public static int Persistence(long n)
            {
                if (n < 11)
                {
                    return 0;
                }
                int count = 0;
                while (n > 9)
                {
                    n = MultDigits(n);
                    count++;
                }
                return count;
            }
            static long MultDigits(long n)
            {
                long mult = 1;
                while (n > 0)
                {
                    mult *= n % 10;
                    n /= 10;
                }
                return mult;
            }
        }

        //https://www.codewars.com/kata/56269eb78ad2e4ced1000013
        public static long FindNextSquare(long sq)
        {
            long r = (long)Math.Sqrt(sq);
            if (r * r != sq)
                return -1;
            return ((r + 1) * (r + 1));
        }

        //https://www.codewars.com/kata/515e271a311df0350d00000f
        public static int SquareSum(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item * item;
            }
            return sum;
        }

        //https://www.codewars.com/kata/square-sums-simple






    }
}
