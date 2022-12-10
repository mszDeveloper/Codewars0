﻿using System;
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
                Array.Sort(intervals, (interval1, interval2) => interval2.Item1.CompareTo(interval1.Item1));
                (int, int) previousInterval = (0, 0);
                int sum = 0;
                foreach (var interval in intervals)
                {
                    if (previousInterval.Item2 >= interval.Item2)
                    {
                        sum += interval.Item2 - previousInterval.Item1;
                    }
                    else
                    {
                        sum += interval.Item2 - interval.Item1;
                    }
                    
                }
                return -1;
            }
        }












    }
}
