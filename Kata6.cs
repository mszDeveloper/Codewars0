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














    }
}
