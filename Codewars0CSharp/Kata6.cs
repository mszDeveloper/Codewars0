using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata6
    {
        //https://www.codewars.com/kata/596144f0ada6db581200004f
        public static int CustomFib(int[] signature, int[] indexes, int n)
        {
            if (n < signature.Length)
            {
                return signature[n];
            }
            int[] result = new int[n + 1];
            Array.Copy(signature, result, signature.Length);
            int sum = 0;
            for (int i = 0; i <= n - signature.Length; i++)
            {
                sum = 0;
                for (int k = 0; k < indexes.Length; k++)
                {
                    sum += result[indexes[k] + i];
                }
                result[signature.Length + i] = sum;
            }
            return result[result.Length - 1];

        }

        //https://www.codewars.com/kata/57a1d5ef7cb1f3db590002af
        public static int Fib(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int result = 0;
            int last = 1;
            int previous = 0;
            for (int i = 0; i < n - 1; i++)
            {
                result = last + previous;
                previous = last;
                last = result;
            }
            return result;
            /**
             *     public static int fib(int n)
                    {
                        int a = 0;
                        int b = 1;
        
                        for (int i = 0; i < n; i++)
                        {
                          int temp = a;
                          a = b;
                          b = temp + a;
                        }
        
                        return a;
                    }

                    public static int fib(int n)
                        {
                               if (n==1||n==2)
                                {
                                    return 1;
                                }
                                return fib(n - 1) + fib(n - 2);
                        }
              public static int fib(int n)
                  {
                    double phi = 0.5 + 0.5 * Math.Sqrt(5);
                    return (int)Math.Round((Math.Pow(phi, n) - Math.Pow(-phi, 1 / n)) / Math.Sqrt(5));
                  }
             */
        }

        //https://www.codewars.com/kata/55688b4e725f41d1e9000065
        public static long Fibonacci(int max)
        {
            long a = 0;
            long b = 1;
            long sum = 0;
            while (true)
            {
                long temp = a;
                a = b;
                b = temp + a;
                if (a % 2 == 0)
                {
                    if (a < max)
                    {
                        sum += a;
                    }
                    else
                    {
                        return sum;
                    }
                }
            }
        }

        //https://www.codewars.com/kata/5648b12ce68d9daa6b000099
        public static int Number(List<int[]> peopleListInOut)
        {
            int result = 0;
            foreach (var item in peopleListInOut)
            {
                result += item[0] - item[1];
            }
            return result;
        }

        //https://www.codewars.com/kata/5949481f86420f59480000e7
        public static string OddOrEven(int[] array)
        {
            if (array.Length == 0)
            {
                return "even";
            }
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            if (sum % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        //https://www.codewars.com/kata/544aed4c4a30184e960010f4
        public static int[] Divisors(int n)
        {
            List<int> result = new();
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);
                }
            }
            if (result.Count == 0)
            {
                return null;
            }
            return result.ToArray();
        }

        //https://www.codewars.com/kata/55b42574ff091733d900002f
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> result = new();
            foreach (var item in names)
            {
                if (item.Length == 4)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        //https://www.codewars.com/kata/578aa45ee9fd15ff4600090d
        public static int[] SortArray(int[] array)
        {
            if (array.Length < 2)
            {
                return array;
            }
            List<int> inputArray = new(array);
            List<(int, int)> even = new();
            int count = inputArray.Count;
            for (int i = 0; i < count; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    even.Add((i, inputArray[i]));
                }
            }
            for (int i = 0; i < count; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    inputArray.RemoveAt(i);
                    i--;
                    count--;
                }
            }
            inputArray.Sort();
            foreach (var item in even)
            {
                inputArray.Insert(item.Item1, item.Item2);
            }
            return inputArray.ToArray();

        //public static int[] SortArray(int[] array)
        //{
        //    List<int> odd = new();
        //    foreach (var item in array)
        //    {
        //        if (item % 2 != 0)
        //        {
        //            odd.Add(item);
        //        }
        //    }
        //    odd.Sort();
        //    for (int i = 0, k = 0; i < array.Length; i++)
        //    {
        //        if (array[i] % 2 != 0)
        //        {
        //            array[i] = odd[k];
        //            k++;
        //        }
        //    }
        //    return array;
        //}

        }

        //https://www.codewars.com/kata/585d7d5adb20cf33cb000235
        public static int GetUnique(IEnumerable<int> numbers)
        {
            List<int> list = new(numbers);
            list.Sort();
            if (list[0] != list[1])
            {
                return list[0];
            }
            else
            {
                return list[^1];
            }
        //public static int GetUnique(IEnumerable<int> numbers)
        //{
        //    List<int> list = new(numbers);
        //    for (int i = 1; i < list.Count - 1; i++)
        //    {
        //        if (list[i] != list[i - 1] && list[i] != list[i + 1])
        //        {
        //            return list[i];
        //        }
        //    }
        //    if (list[0] != list[1])
        //    {
        //        return list[0];
        //    }
        //    else
        //    {
        //        return list[^1];
        //    }
        //}
        }


    }
}
