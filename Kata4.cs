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
















    }
}
