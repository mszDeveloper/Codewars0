using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata2
    {
        public static int TrailingZeros(int n)
        {
            //https://www.youtube.com/watch?v=9GhiTWjhB60
            //https://brilliant.org/wiki/trailing-number-of-zeros/
            int count = 0;
            int multiplier = 5;
            while (true)
            {
                int currentCoutn = n / multiplier;
                if (currentCoutn.Equals(0))
                {
                    break;
                }
                count += currentCoutn;
                multiplier *= 5;
            }
            return count;
            /*
             *   public static int TrailingZeros(int n)
                  { 
                    int fives = 0;
                    for (int i = 5; i <= n; i *= 5)
                        fives += n/i;
    
                    return fives;
                  }
             */
        }

        public class SumStrings
        {
            public static string sumStrings(string a, string b)
            {
                if (a.Length.Equals(0) && b.Length.Equals(0))
                {
                    return "0";
                }
                if (!a.Length.Equals(0) && b.Length.Equals(0))
                {
                    return a;
                }
                if (a.Length.Equals(0) && !b.Length.Equals(0))
                {
                    return b;
                }

                StringBuilder aMut = new(a);
                StringBuilder bMut = new(b);
                RemoveLeadingZeros(ref aMut);
                RemoveLeadingZeros(ref bMut);

                int smallerLength, biggerLength;
                StringBuilder smallerString, biggerString;
                if (aMut.Length >= bMut.Length)
                {
                    smallerLength = bMut.Length;
                    biggerLength = aMut.Length;
                    smallerString = bMut;
                    biggerString = aMut;
                }
                else
                {
                    smallerLength = aMut.Length;
                    biggerLength = bMut.Length;
                    smallerString = aMut;
                    biggerString = bMut;
                }

                int zerosCount = biggerLength - smallerLength;
                if (zerosCount > 0)
                {
                    StringBuilder zeros = new();
                    for (int i = 0; i < zerosCount; i++)
                    {
                        zeros.Append('0');
                    }
                    zeros.Append(smallerString);
                    smallerString = zeros;
                }

                int add = 0;
                StringBuilder result = new();
                for (int index = biggerLength - 1; index >= 0; index--)
                {
                    int digitsSum = Int32.Parse(biggerString[index].ToString()) + Int32.Parse(smallerString[index].ToString()) + add;
                    if (digitsSum > 9)
                    {
                        add = 1;
                        digitsSum %= 10;
                    }
                    else
                    {
                        add = 0;
                    }
                    result.Append(digitsSum);
                }
                if (add > 0)
                {
                    result.Append(add);
                }
                char[] chars = result.ToString().ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }

            static void RemoveLeadingZeros(ref StringBuilder str)
            {
                int length = str.Length;
                while (length > 1)
                {
                    if (str[0].Equals('0'))
                    {
                        str.Remove(0, 1);
                        length--;
                    }
                    else break;
                }
            }
            /*
                using System;
                using System.Numerics;

                public static class Kata
                {
                    public static string sumStrings(string a, string b)
                    {
                      BigInteger aInt;
                      BigInteger bInt;
      
                      BigInteger.TryParse(a, out aInt);
                      BigInteger.TryParse(b, out bInt);
      
                      return (aInt + bInt).ToString();
                    }
                }
            */
        }

        public class SnailSolution
        {
            public static int[] Snail(int[][] array)
            {
                List<int> resultList = new();
                int length = array.Length;
                if (length.Equals(0))
                {
                    return Array.Empty<int>();
                }
                if (array[0].Length.Equals(0))
                {
                    return Array.Empty<int>();
                }
                bool horizontal = true, forward = true;
                int col = 0, row = 0, limiter = 0;
                while (true)
                {
                    if (forward)
                    {
                        if (horizontal)
                        {
                            if (col.Equals(length - 1 - limiter))
                            {
                                horizontal = false;
                                if (limiter >= (int)Math.Ceiling((double)length / 2))
                                {
                                    resultList.Add(array[row][col]);
                                    break;
                                }
                                continue;
                            }
                            resultList.Add(array[row][col]);
                            col++;
                        }
                        else
                        {
                            if (row.Equals(length - 1 - limiter))
                            {
                                horizontal = true;
                                forward = false;
                                continue;
                            }
                            resultList.Add(array[row][col]);
                            row++;
                        }
                    }
                    else
                    {
                        if (horizontal)
                        {
                            if (col.Equals(0 + limiter))
                            {
                                horizontal = false;
                                limiter++;
                                if (limiter >= (int)Math.Ceiling((double)length / 2))
                                {
                                    resultList.Add(array[row][col]);
                                    break;
                                }
                                continue;
                            }
                            resultList.Add(array[row][col]);
                            col--;
                        }
                        else
                        {
                            if (row.Equals(0 + limiter))
                            {
                                horizontal = true;
                                forward = true;
                                continue;
                            }
                            resultList.Add(array[row][col]);
                            row--;
                        }
                    }

                }
                return resultList.ToArray();
            }

            /*
             * 
             * public class SnailSolution
                {
                    public static int[] Snail(int[][] array)
                    {
                        int l = array[0].Length;
                        int[] sorted = new int[l * l];
                        Snail(array, -1, 0, 1, 0, l, 0, sorted);
                        return sorted;
                    }

                    public static void Snail(int[][] array, int x, int y, int dx, int dy, int l, int i, int[] sorted)
                    {
                        if (l == 0)
                            return;
                        for (int j = 0; j < l; j++)
                        {
                            x += dx;
                            y += dy;
                            sorted[i++] = array[y][x];
                        }
                        Snail(array, x, y, -dy, dx, dy == 0 ? l - 1 : l, i, sorted);
                    }
                }
             */
        }

        //https://www.codewars.com/kata/5a3af5b1ee1aaeabfe000084
        public class SumOfSquares
        {
            //static bool IsInteger(double number)
            //{
            //    //return number == (long)number;
            //    //return Math.Abs(number % 1) <= (Double.Epsilon * 100);
            //    //return (double)((int)number) == number;
            //    return Math.Ceiling(number) == Math.Floor(number);
            //}
            //static bool IsFinite(double d)
            //{
            //    long bits = BitConverter.DoubleToInt64Bits(d);
            //    return (bits & 0x7FFFFFFFFFFFFFFF) < 0x7FF0000000000000;
            //}
            //static bool IsInteger(double value) => IsFinite(value) && (value == Math.Truncate(value));
            //static bool IsInteger(decimal value) => value == Math.Truncate(value);

            //public static long FindNextSquare(long sq)
            //{
            //    long r = (long)Math.Sqrt(sq);
            //    if (r * r != sq)
            //        return -1;
            //    return ((r + 1) * (r + 1));
            //}

            public static int NSquaresFor1(int n)
            {
                if (IsInteger(Math.Sqrt(n)))
                {
                    return 1;
                }
                int result1 = 0, result2 = 0, result3 = 0;
                int a1 = n, a2 = n, a3 = n;
                int b1 = n - 1, b2 = n - 1, b3 = n - 1;
                int i1 = 0, i2 = 0;
                //while (true)
                //{
                //    if (IsInteger(Math.Sqrt(b1)))
                //    {
                //        Console.WriteLine(b1);
                //        //if (b1 <= 1)
                //        //{
                //        //    break;
                //        //}
                //        //b1--;
                //        result1++;
                //        a1 -= b1;
                //        if (a1.Equals(0))
                //        {
                //            break;
                //        }
                //        b1 = a1;
                //    }
                //    else
                //    {
                //        b1--;
                //        continue;
                //    }
                //}
                //while (true)
                //{
                //    if (IsInteger(Math.Sqrt(b2)))
                //    {
                //        i1++;
                //        if (i1 <= 1)
                //        {
                //            b2--;
                //            continue;
                //        }
                //        result2++;
                //        //Console.WriteLine(b2);
                //        a2 -= b2;
                //        if (a2.Equals(0))
                //        {
                //            break;
                //        }
                //        b2 = a2;
                //    }
                //    else
                //    {
                //        b2--;
                //        continue;
                //    }
                //}
                //while (true)
                //{
                //    if (IsInteger(Math.Sqrt(b3)))
                //    {
                //        i2++;
                //        if (i2 <= 2)
                //        {
                //            b3--;
                //            continue;
                //        }
                //        result3++;
                //        a3 -= b3;
                //        if (a3.Equals(0))
                //        {
                //            break;
                //        }
                //        b3 = a3;
                //    }
                //    else
                //    {
                //        b3--;
                //        continue;
                //    }
                //}
                //Console.WriteLine(result1);
                //Console.WriteLine(result2);
                //Console.WriteLine(result3);
                //return Math.Min(result1, result2);

                List<int> results = new();
                for (int i = 0; i <= n / 2; i++)
                {
                    Console.WriteLine(i);
                    int result4 = 0;
                    int a4 = n;
                    int b4 = n - 1;
                    int i4 = 0;
                    while (true)
                    {
                        if (IsInteger(Math.Sqrt(b4)))
                        {
                            i4++;
                            if (i4 <= i)
                            {
                                b4--;
                                continue;
                            }
                            result4++;
                            a4 -= b4;
                            if (a4.Equals(0))
                            {
                                break;
                            }
                            b4 = a4;
                        }
                        else
                        {
                            b4--;
                            continue;
                        }
                    }
                    results.Add(result4);
                    Console.WriteLine(result4);
                }
                return results.Min();

            }
            public static int NSquaresFor(int n)
            {
                Console.WriteLine(n);
                if (IsPerfectSquare(n)) return 1;

                //https://ru.wikipedia.org/wiki/Теорема_Ферма_—_Эйлера
                //https://en.wikipedia.org/wiki/Fermat%27s_theorem_on_sums_of_two_squares
                //https://www.youtube.com/watch?v=ZltHgJU0t5M
                //https://www.youtube.com/playlist?list=PL1JJ1jVZ9z5BBcrqGsD4a-bte3BQs6SAM
                if (n % 4 == 1 && IsPrime(n)) return 2;

                bool IsNumberDontHaveTwoSquare = (n % 4 == 3) || (n % 3 == 0 && n % 9 != 0);
                if (IsNumberDontHaveTwoSquare)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }

                //https://ru.wikipedia.org/wiki/Теорема_Лагранжа_о_сумме_четырёх_квадратов
                //https://en.wikipedia.org/wiki/Lagrange%27s_four-square_theorem

                //представить в виде суммы квадратов, затем суммировать слагаемые и проверять на совершенный квадрат.

                //https://ru.stackoverflow.com/questions/1174981/Разложить-число-на-кратчайшую-сумму-квадратов


            }
            static bool IsPerfectSquare(long number)
            {
                long root = (long)Math.Sqrt(number);
                return root * root == number;
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
            public static int NSquaresForRec(int n)
            {
                int result = 0;
                int first = 0;
                for (int i = n; i >= 4; i--)
                {
                    if (IsInteger(Math.Sqrt(i)))
                    {
                        first = i;
                        result++;
                        break;
                    }
                }
                result += NSquaresForRec(n - first);
                return result;
            }

            static bool IsInteger(double number)
            {
                return number == (int)number;
            }

            ///
            public static int FindNumberOfSquares(int n, int first)
            {
                // Assume the first root and go from there.
                int result = 1;
                n -= first * first;

                // If in any case (shouldn't ever happen) the first root we passed is too big, return int.MaxValue.
                if (n < 0)
                {
                    return int.MaxValue;
                }

                // While the number is above zero:
                // 1. Get the first possible integer root, e.g. for 3622 it would be 60.
                // 2. Increment result (we found a perfect root), subtract the value from n, e.g. 3622 - 60^2 = 22.
                // 3. Repeat until we get to 0.
                while (n != 0)
                {
                    int root = (int)Math.Sqrt(n);
                    result++;
                    n -= root * root;
                }

                return result;
            }

            public static int NSquaresFor2(int n)
            {
                Console.WriteLine(n);

                // For n=1, result = 1. For n=2, result = 2.
                if (n < 3)
                {
                    return n;
                }

                int perfectRoot = (int)Math.Sqrt(n);

                // If number is already a perfect square, return 1.
                if (perfectRoot * perfectRoot == n)
                {
                    return 1;
                }

                var list = new List<int>();

                // Start from the first possible root (Sqrt(n)) and go down.
                // i will be the first assumed element in the sequence.
                // This will not exceed 32000 iterations in the most extreme cases (quite low).
                for (int i = (int)Math.Sqrt(n); i > 0; --i)
                {
                    list.Add(FindNumberOfSquares(n, i));
                }

                // Select the lowest value out of all.
                // This is necessary in cases like n=18, where normally the result would be 3 (4^2+1^2+1^2),
                // but the correct answer is 2 (3^2+3^2).
                return list.Min();
            }

            ///
            private static bool IsPerfectSquare(int n) => Math.Abs(Math.Ceiling(Math.Sqrt(n)) - Math.Floor(Math.Sqrt(n))) < double.Epsilon;

            public static int NSquaresFor3(int n)
            {
                if (IsPerfectSquare(n)) return 1;
                //Now, as long we can divide by 4, do this...
                while (n % 4 == 0) n /= 4;
                //Then check if the remainder of a division by 8 equals 7, if it is, the result will be 4 (see 15 for example)
                if (n % 8 == 7) return 4;
                //Finally, check the powers
                for (int p = 0; p * p < n; ++p)
                    if (IsPerfectSquare(n - p * p)) return 2;
                //This is the only case left...
                return 3;
            }

            ///
            private static bool isSquare(int x)
            {
                return (Math.Sqrt(x) % 1 == 0);
            }

            //This code is based on Lagrange’s Four Square Theorem.
            //There can be no more than 4 solutions to this problem, based on this theorem.
            // Answer 1 is applicable to an input that is actually a perfect square
            // Answer 2 is the result when the input is the sum of 2 square numbers
            // Answer 3 is the result when the input not of the form 4^k(8m + 7)
            // Answer 4 is the number when the input is of the form 4^k(8m + 7)
            public static int NSquaresFor4(int n)
            {
                //First check if it is a perfect square (the answer will be 1)
                if (isSquare(n)) return 1;

                //Second, check the 2nd outcome of the theorem
                var list = Enumerable.Range(1, (int)(Math.Sqrt(n))).ToList();
                for (int i = 1; i <= list.Count - 1; i++)
                    if (isSquare(n - (i * i))) return 2;

                //Third, check the fourth outcome of the theorem
                while (n % 4 == 0) n >>= 2;
                if (n % 8 == 7) return 4;

                //The only remaining answer can only still be 3...
                return 3;
            }

        }

































    }
}
