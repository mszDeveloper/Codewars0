﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata1
    {
        public static string Likes(string[] name)
        {
            string displayText = String.Empty;
            string oneLikeText = " likes this";
            string likeText = " like this";
            string noOneLikesText = "no one" + oneLikeText;
            int othersNamesCount = 4;
            if (name.Length.Equals(0))
            {
                displayText = noOneLikesText;
            }
            if (name.Length.Equals(1))
            {
                displayText = name.First() + oneLikeText;
            }
            if (name.Length.Equals(2))
            {
                displayText = name.First() + " and " + name.Last() + likeText;
            }
            if (name.Length.Equals(3))
            {
                displayText = name.First() + ", " + name[1] + " and " + name.Last() + likeText;
            }
            if (name.Length >= othersNamesCount)
            {
                displayText = name.First() + ", " + name[1] + " and " + (name.Length - 2).ToString() + " others" + likeText;
            }
            return displayText;
        }

        public static int MaxSequence(int[] arr)
        {
            int maxSum = 0;
            int currentSum = 0;
            foreach (var item in arr)
            {
                currentSum += item;
                currentSum = Math.Max(currentSum, 0);
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;
        }

        public class DigPow
        {
            public static long digPow(int n, int p)
            {
                // your code
                return -1;
            }
        }























    }
}
