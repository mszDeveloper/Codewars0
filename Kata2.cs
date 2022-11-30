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

        public class SumOfSquares
        {
            static bool IsInteger(double number)
            {
                return number == (int)number;
            }
            public static int NSquaresFor(int n)
            {
                if (IsInteger(Math.Sqrt(n)))
                {
                    return 1;
                }
                int result1 = 0, result2 = 0, result3 = 0;
                int a1 = n, a2 = n, a3 = n;
                int b1 = n - 1, b2 = n - 1, b3 = n - 1;
                int i1 = 0, i2 = 0;
                while (true)
                {
                    if (IsInteger(Math.Sqrt(b1)))
                    {
                        //Console.WriteLine(b);
                        result1++;
                        a1 -= b1;
                        if (a1.Equals(0))
                        {
                            break;
                        }
                        b1 = a1;
                    }
                    else
                    {
                        b1--;
                        continue;
                    }
                }
                while (true)
                {
                    if (IsInteger(Math.Sqrt(b2)))
                    {
                        i1++;
                        if (i1 <= 1)
                        {
                            b2--;
                            continue;
                        }
                        result2++;
                        a2 -= b2;
                        if (a2.Equals(0))
                        {
                            break;
                        }
                        b2 = a2;
                    }
                    else
                    {
                        b2--;
                        continue;
                    }
                }
                while (true)
                {
                    if (IsInteger(Math.Sqrt(b3)))
                    {
                        i2++;
                        if (i2 <= 2)
                        {
                            b3--;
                            continue;
                        }
                        result3++;
                        a3 -= b3;
                        if (a3.Equals(0))
                        {
                            break;
                        }
                        b3 = a3;
                    }
                    else
                    {
                        b3--;
                        continue;
                    }
                }
                Console.WriteLine(result1);
                Console.WriteLine(result2);
                Console.WriteLine(result3);
                return Math.Min(result1, result2);
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

                //List<int> results = new();
                //for (int i = 1; i < result1; i++)
                //{
                //    int result4 = 0;
                //    int a4 = n;
                //    int b4 = n - 1;
                //    int i4 = 0;
                //    while (true)
                //    {
                //        if (IsInteger(Math.Sqrt(b4)))
                //        {
                //            i4++;
                //            if (i4 <= i)
                //            {
                //                b4--;
                //                continue;
                //            }
                //            result4++;
                //            a4 -= b4;
                //            if (a4.Equals(0))
                //            {
                //                break;
                //            }
                //            b4 = a4;
                //        }
                //        else
                //        {
                //            b4--;
                //            continue;
                //        }
                //    }
                //    results.Add(result4);
                //}

        }

































    }
}
