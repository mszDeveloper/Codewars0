using System;

namespace Codewars0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ///////////////////////////////////////////

            //int[][] matrix = new int[][] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
            //int[] result = Kata2.SnailSolution.Snail(matrix);
            //int result = Kata2.SumOfSquares.NSquaresFor(3456);
            long[] result = Kata3.OddDigPrime.OnlyOddDigPrimes(20);
            Console.WriteLine("result == ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            ///////////////////////////////////////////
            Console.WriteLine("Ready!");
        }
    }


}
