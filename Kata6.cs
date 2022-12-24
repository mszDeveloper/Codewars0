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
            int sum = 0;
            for (int i = 0; i <= n - signature.Length; i++)
            {
                sum = 0;
                for (int k = i; k < indexes.Length; k++)
                {
                    sum += signature[indexes[k]];
                }
            }

        }
















    }
}
