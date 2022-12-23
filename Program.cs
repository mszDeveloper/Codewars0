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
            //long[] result = Kata3.OddDigPrime.OnlyOddDigPrimes(20);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //int result = Kata4.Intervals.SumIntervals(new (int, int)[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) });
            //bool result = Kata4.PowerOf4(1024);
            double result = Kata5.Geo_Mean(new int[] { 1, 2 }, 3);
            Console.WriteLine("result == ");
            Console.WriteLine(result);

            ///////////////////////////////////////////
            Console.WriteLine("Ready!");
        }
    }


}
