using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata4
    {
        //https://www.codewars.com/kata/634d0f7c562caa0016debac5
        public static bool HasSurvived(int[] attackers, int[] defenders)
        {
            int attackersSurv = 0;
            int defendersSurv = 0;
            int attackersCount = attackers.Length;
            int defendersCount = defenders.Length;
            int minCount = attackersCount;
            if (attackersCount > defendersCount)
            {
                attackersSurv = attackersCount - defendersCount;
                minCount = defendersCount;
            }
            if (defendersCount > attackersCount)
            {
                defendersSurv = defendersCount - attackersCount;
            }

            for (int i = 0; i < minCount; i++)
            {
                if (attackers[i] > defenders[i])
                {
                    attackersSurv++;
                }
                if (defenders[i] > attackers[i])
                {
                    defendersSurv++;
                }
            }
            if (attackersSurv == defendersSurv)
            {
                int attackersPower = 0;
                int defendersPower = 0;
                for (int i = 0; i < attackersCount; i++)
                {
                    attackersPower += attackers[i];
                }
                for (int i = 0; i < defendersCount; i++)
                {
                    defendersPower += defenders[i];
                }
                return defendersPower >= attackersPower;
            }
            return defendersSurv >= attackersSurv;
        }

        //https://www.codewars.com/kata/51ba717bb08c1cd60f00002f
        public class RangeExtraction
        {
            public static string Extract(int[] args)
            {
                StringBuilder str = new();
                str.Append(args[0]);
                int previous = args[0];
                bool isChain = false;
                int chainLength = 0;
                for (int i = 1; i < args.Length; i++)
                {
                    if ((args[i] - previous) == 1)
                    {
                        isChain = true;
                        chainLength++;
                    }
                    else
                    {
                        if (isChain)
                        {
                            if (chainLength > 1)
                            {
                                str.Append("-").Append(previous);
                            }
                            else
                            {
                                str.Append(",").Append(previous);
                            }
                            isChain = false;
                            chainLength = 0;
                        }
                        str.Append(",").Append(args[i]);
                    }
                    previous = args[i];
                }
                if (isChain)
                {
                    if (chainLength > 1)
                    {
                        str.Append("-").Append(previous);
                    }
                    else
                    {
                        str.Append(",").Append(previous);
                    }
                }
                return str.ToString();
            }
        }

        //https://www.codewars.com/kata/5544c7a5cb454edb3c000047
        public class BouncingBall
        {
            public static int bouncingBall(double h, double bounce, double window)
            {
                if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
                {
                    return -1;
                }
                int count = -1;
                while (h > window)
                {
                    count += 2;
                    h *= bounce;
                }
                return count;
            }
        }

        //https://www.codewars.com/kata/52b7ed099cdc285c300001cd
        public class Intervals
        {
            public static int SumIntervals((int, int)[] intervals)
            {
                if (intervals.Length == 0)
                {
                    return 0;
                }
                Array.Sort(intervals, (interval1, interval2) => interval1.Item1.CompareTo(interval2.Item1));
                (int, int) previousInterval = intervals[0];
                int sum = intervals[0].Item2 - intervals[0].Item1;
                int lastAdd = sum;
                for (int i = 1; i < intervals.Length; i++)
                {
                    if (previousInterval.Item2 > intervals[i].Item2)
                    {
                        continue;
                    }
                    if (previousInterval.Item2 > intervals[i].Item1)
                    {
                        sum -= lastAdd;
                        lastAdd = intervals[i].Item2 - previousInterval.Item1;
                        previousInterval.Item2 = intervals[i].Item2;
                    }
                    else
                    {
                        lastAdd = intervals[i].Item2 - intervals[i].Item1;
                        previousInterval = intervals[i];
                    }
                    sum += lastAdd;
                }
                return sum;
            }
            /*
             *     public static int SumIntervals((int, int)[] intervals)
                    {
                        Array.Sort(intervals, (x,y) => x.Item1 - y.Item1);
                        int max = int.MinValue;
                        int total = 0;
                        foreach (var interval in intervals) 
                        {
                            max = Math.Max(max, interval.Item1);
                            total += Math.Max(0, interval.Item2 - max);
                            max = Math.Max(max, interval.Item2);
                        }
                        return total;
                    }
             */
        }

        //https://www.codewars.com/kata/5993fb6c4f5d9f770c0000f2
        public static int SumNoDuplicates(int[] arr)
        {
            Array.Sort(arr);
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0 && arr[i] == arr[i - 1])
                {
                    continue;
                }
                if (i != (arr.Length - 1) && arr[i] == arr[i + 1])
                {
                    continue;
                }
                sum += arr[i];
            }
            return sum;
        }

        //https://www.codewars.com/kata/61123a6f2446320021db987d
        public static int? PreviousMultipleOfThree(int n)
        {
            while (n != 0)
            {
                if (n % 3 == 0)
                {
                    return n;
                }
                n = n / 10;
            }
            return null;
        }

        //https://www.codewars.com/kata/544d114f84e41094a9000439
        public class Power
        {
            public static bool PowerOf4_1(object n)
            {
                if (n is Int16 || n is Int32)
                {
                    int number = (int)n;
                    Console.WriteLine(number);
                    if (number == 1)
                    {
                        return true;
                    }
                    if (number <= 0 || number % 4 != 0)
                    {
                        return false;
                    }
                    double numberD = (double)number;
                    while (numberD > 1)
                    {
                        numberD /= 4;
                        if (numberD == 1 || number == 2)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else return false;
            }
            public static bool PowerOf4(object n)
            {
                if (n is Int16 || n is Int32)
                {
                    int number = (int)n;
                    Console.WriteLine(number);
                    if (number == 1)
                    {
                        return true;
                    }
                    if (number <= 0 || number % 4 != 0)
                    {
                        return false;
                    }
                    double i = Math.Log(number) / Math.Log(4);
                    return i == (int)i;
                }
                else return false;
            }
            static bool IsInteger(double number)
            {
                return number == (int)number;
            }
            public static int PowerOf4Line()
            {
                double i = 0;
                while ((int)i <= 5)
                {
                    //return (int)Math.Pow(4, i);
                    Console.WriteLine(Math.Pow(4, i));
                    i += 0.5;
                }
                return -1;
            }
        }

        //https://www.codewars.com/kata/55f2b110f61eb01779000053
        public int GetSum(int a, int b)
        {
            int begin = Math.Min(a, b);
            int end = Math.Max(a, b);
            int sum = 0;
            while (begin <= end)
            {
                sum += begin;
                begin++;
            }
            return sum;
        }
        //https://ru.wikipedia.org/wiki/Арифметическая_прогрессия
        //public int GetSum(int a, int b)
        //{
        //    return (a + b) * (Math.Abs(a - b) + 1) / 2;
        //}

        //https://www.codewars.com/kata/57f609022f4d534f05000024
        public static int Stray(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] != numbers[i - 1] && numbers[i] != numbers[i + 1])
                {
                    return numbers[i];
                }
            }
            if (numbers[0] != numbers[1])
            {
                return numbers[0];
            }
            else
            {
                return numbers[numbers.Length - 1];
            }
        }















    }
}
