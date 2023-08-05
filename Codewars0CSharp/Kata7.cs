﻿using System;
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
        public class SquareSumSimple
        {
            static bool IsPerfectSquare(long number)
            {
                long root = (long)Math.Sqrt(number);
                return root * root == number;
            }
            static void Swap(ref int[] arr, int index1, int index2)
            {
                int tmp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = tmp;
            }
            static int[] CreateArray(int length)
            {
                int[] arr = new int[length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i + 1;
                }
                return arr;
            }
            static int FindNextPower(int number, int pow = 2)
            {
                double root = Math.Pow(number + 1, 1.0 / pow);
                double ceilRoot = Math.Ceiling(root);
                double nextPower = Math.Pow(ceilRoot, pow);
                return (int)nextPower;
            }
            static bool IsNumberInArr(ref List<int> arr, int n)
            {
                if (arr.Count == 0)
                {
                    return false;
                }
                foreach (var item in arr)
                {
                    if (item == n)
                    {
                        return true;
                    }
                }
                return false;
            }

            static int[] SquareSumRec(int a, int n, ref List<int> arr)
            {
                int b = 0;
                int c = a;
                while (true)
                {
                    c = FindNextPower(c);
                    b = c - a;
                    if (b == a || IsNumberInArr(ref arr, b)) continue;
                    if (b > n) break;
                    List<int> arrNext = new(arr);
                    //Console.WriteLine(b);
                    arrNext.Add(b);
                    if (arrNext.Count == n)
                    {
                        return arrNext.ToArray();
                    }
                    int[] resultArr = SquareSumRec(b, n, ref arrNext);
                    if (resultArr != null)
                    {
                        return resultArr;
                    }
                    //Console.WriteLine("===");
                }
                return null;
            }
            public static int[] SquareSum(int n)
            {
                for (int a = 1; a <= n; a++)
                {
                    List<int> arr = new(n);
                    arr.Add(a);
                    //Console.WriteLine("a = " + a.ToString());
                    int[] resultArr = SquareSumRec(a, n, ref arr);
                    //Console.WriteLine("===========");
                    if (resultArr != null)
                    {
                        return resultArr;
                    }
                }
                return null;
            }
            //public static int[] SquareSum2(int n)
            //{
            //    List<int> arr = new();
            //    for (int i = 1; i <= n; i++)
            //    {
            //        arr.Clear();
            //        if (!IsNumberInArr(ref arr, i))
            //        {
            //            arr.Add(i);
            //            Console.WriteLine("i = " + i.ToString());
            //        }
            //        else continue;
            //        //bool isSumFind = false;
            //        int k = i;
            //        for (int j = 1; j <= n; j++)
            //        {
            //            if (k != j && IsPerfectSquare(k + j) && !IsNumberInArr(ref arr, j))
            //            {
            //                arr.Add(j);
            //                Console.WriteLine("j = " + j.ToString());
            //                k = j;
            //                j = 0;
            //                if (arr.Count == n)
            //                {
            //                    return arr.ToArray();
            //                }
            //            }
            //            else continue;
            //        }
            //    }
            //    //if (arr.Count == n)
            //    //{
            //    return arr.ToArray();
            //    //}
            //    //else return Array.Empty<int>();
            //}

            //public static int[] SquareSum1(int n)
            //{
            //    //int[] arr = CreateArray(n);
            //    //List<int> listArr = new(arr);
            //    //int index = 0;

            //    List<int[]> listPairs = new();

            //    //while (true)
            //    //{
            //        int nextSquare = FindNextPower(n, 2);    
            //        int first = nextSquare - n;
            //        int last = (nextSquare - 1) / 2;
            //        int count = first;
            //        while (count <= last)
            //        {
            //            listPairs.Add(new int[2] { count, nextSquare - count });
            //            count++;
            //        }
            //    //    n = first - 1;
            //    //    if (n == 0)
            //    //    {
            //    //        break;
            //    //    }
            //    //    if (n < 15)
            //    //    {
            //    //        return Array.Empty<int>();
            //    //    }

            //    //}
            //    foreach (var item in listPairs)
            //    {
            //        Console.WriteLine(item[0]);
            //        Console.WriteLine(item[1]);
            //    }
            //    return Array.Empty<int>();
            //    //return arr;
            //}

        }

        //https://www.codewars.com/kata/54da539698b8a2ad76000228
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10) return false;
            Vector2 pos = Vector2.Zero;
            for (int i = 0; i < 10; i++)
            {
                if (walk[i] == "w") pos.X--;
                if (walk[i] == "e") pos.X++;
                if (walk[i] == "s") pos.Y--;
                if (walk[i] == "n") pos.Y++;
            }
            return pos == Vector2.Zero;
        }

        //https://www.codewars.com/kata/57eb8fcdf670e99d9b000272
        public static string High(string s)
        {
            int i = 1;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> dict = new();
            foreach (var item in alphabet)
            {
                dict.Add(item, i);
                i++;
            }
            int high = 0;
            int score = 0;
            string highStr = String.Empty;
            StringBuilder currentStr = new();
            foreach (var item in s)
            {
                if (item == ' ')
                {
                    if (score > high)
                    {
                        high = score;
                        highStr = currentStr.ToString();
                    }
                    score = 0;
                    currentStr.Clear();
                    continue;
                }
                currentStr.Append(item);
                score += dict.GetValueOrDefault(item);
            }
            if (score > high)
            {
                highStr = currentStr.ToString();
            }
            return highStr;
        }

    }
}
