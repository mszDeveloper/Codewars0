using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata5
    {
        //https://www.codewars.com/kata/53dbd5315a3c69eed20002dd
        public class ListFilterer
        {
            public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
            {
                List<int> result = new();
                foreach (var item in listOfItems)
                {
                    if (item is int)
                    {
                        result.Add((int)item);
                    }
                }
                return result;
                //return listOfItems.OfType<int>();
            }
        }

        //https://www.codewars.com/kata/5583090cbe83f4fd8c000051
        class Digitizer
        {
            static string Reverse(string str)
            {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            public static long[] Digitize(long n)
            {
                string numberStr = n.ToString();
                string reversStr = Reverse(numberStr);
                List<long> numberList = new();
                foreach (var item in reversStr)
                {
                    numberList.Add(int.Parse(item.ToString()));
                }
                return numberList.ToArray();
            }
        }

        //https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9
        public static int FindShort(string s)
        {
            int curCount = 0;
            int minCount = s.Length;
            foreach (var item in s)
            {
                if (item == ' ')
                {
                    if (curCount < minCount)
                    {
                        minCount = curCount;
                    }
                    curCount = 0;
                    continue;
                }
                curCount++;
            }
            if (curCount < minCount)
            {
                minCount = curCount;
            }
            return minCount;
            /*
             *   public static int FindShort(string s)
                  {
                    int shortest = int.MaxValue;
                    foreach (string word in s.Split(' ')) {
                      shortest = Math.Min(word.Length, shortest);
                    }
                    return shortest;
                  }
             */
        }

        //https://www.codewars.com/kata/58aa5d32c9eb04d90b000107
        public class KataMobius
        {
            public int Mobius(double n)
            {
                


            }
        }




















        }
}
