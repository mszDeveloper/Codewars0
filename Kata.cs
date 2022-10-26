using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata
    {
        public static double SumArray(double[] array)
        {
            if (array.Length.Equals(0))
            {
                return 0;
            }
            if (array.Length.Equals(1))
            {
                return array[0];
            }
            double sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
            //return array.Sum();
        }

        public static string AlphabetPosition(string text)
        {
            Dictionary<string, string> alphabet = new()
            {
                { "a", "1" },
                { "b", "2" },
                { "c", "3" },
                { "d", "4" },
                { "e", "5" },
                { "f", "6" },
                { "g", "7" },
                { "h", "8" },
                { "i", "9" },
                { "j", "10" },
                { "k", "11" },
                { "l", "12" },
                { "m", "13" },
                { "n", "14" },
                { "o", "15" },
                { "p", "16" },
                { "q", "17" },
                { "r", "18" },
                { "s", "19" },
                { "t", "20" },
                { "u", "21" },
                { "v", "22" },
                { "w", "23" },
                { "x", "24" },
                { "y", "25" },
                { "z", "26" }
            };
            string positions = "";
            if (text.Length.Equals(0))
            {
                return positions;
            }
            foreach (var item in text)
            {
                string itemString = item.ToString().ToLower();
                if (!alphabet.ContainsKey(itemString))
                {
                    continue;
                }
                positions += alphabet[itemString];
                positions += " ";
            }

            positions = positions.TrimEnd();
            return positions;

            //https://www.codewars.com/kata/546f922b54af40e1e90001da/solutions/csharp
            //using System.Linq;
            //return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
            //Each of the char is the incoming string represented by x in here. By making this: (x-'a') we are convert it inside compiler into int ('a' = 1) and then just add this 1 back to the value (+1). For example: ('b' - 'a' + 1) = 2 equals to (2 - 1 + 1)
        }

        public class Parentheses
        {
            public static bool ValidParentheses(string input)
            {
                if (input.Length.Equals(0)) return true;
                if (input.Length < 2 || input.Length > 100) return false;
                if (input.First().Equals(')') || input.Last().Equals('(')) return false;
                var parenthesis = new StringBuilder();
                foreach (var item in input)
                {
                    if (item.Equals('(') || item.Equals(')'))
                    {
                        parenthesis.Append(item);
                    }
                }
                if (!(parenthesis.Length % 2).Equals(0) || parenthesis.Length.Equals(0)) return false;
                for (int index = 0; ;)
                {
                    if (index >= parenthesis.Length) break;
                    if (index.Equals(parenthesis.Length - 1) && parenthesis[index].Equals('(')) return false;
                    if (parenthesis[index].Equals('(') && parenthesis[index + 1].Equals(')'))
                    {
                        parenthesis = parenthesis.Remove(index, 2);
                        if (parenthesis.Length.Equals(0)) return true;
                        if (!index.Equals(0)) index--;
                        continue;
                    }
                    index++;
                }
                return false;
            }

        }

        public static void ReverseString(ref StringBuilder str)
        {
            for (int index = 0; index < str.Length / 2; index++)
            {
                var tmpChar = str[index];
                str[index] = str[str.Length - 1 - index];
                str[str.Length - 1 - index] = tmpChar;
            }
        }
        public static string SpinWords(string sentence)
        {
            var result = new StringBuilder();
            var tmpWord = new StringBuilder();
            foreach (var item in sentence)
            {
                if (!item.Equals(' '))
                {
                    tmpWord.Append(item);
                    continue;
                }
                if (tmpWord.Length < 5)
                {
                    result.Append(tmpWord + " ");
                }
                else
                {
                    ReverseString(ref tmpWord);
                    result.Append(tmpWord + " ");
                }
                tmpWord.Clear();
            }
            //Last word.
            if (tmpWord.Length < 5 && !sentence.Last().Equals(' '))
            {
                result.Append(tmpWord);
            }
            if (tmpWord.Length >= 5)
            {
                ReverseString(ref tmpWord);
                result.Append(tmpWord);
            }
            return result.ToString();
            //return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
            /*
             * 
             *   public static string SpinWords(string sentence)
                  {
                    string[] words = sentence.Split();

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Length >= 5)
                        {
                            words[i] = new string(words[i].Reverse().ToArray());
                        }
                    }

                    return string.Join(" ", words);
                  }
             */
        }

        public static bool Narcissistic(int value)
        {
            int digitCount = 0;
            int currentValue = value;
            while (true)
            {
                currentValue = currentValue / 10;
                digitCount++;
                if (currentValue.Equals(0))
                {
                    break;
                }
            }
            if (digitCount.Equals(1)) return true;
            currentValue = value;
            long sum = 0;
            int remainder = 0;
            for (int i = 0; i < digitCount; i++)
            {
                remainder = currentValue % 10;
                sum += Convert.ToInt64(Math.Pow(remainder, digitCount));
                currentValue = currentValue / 10;
            }
            return sum.Equals(value);
        }

        public class Revrot
        {
            public static string RevRot(string strng, int sz)
            {
                if (strng.Length.Equals(0) || sz <= 0 || strng.Length < sz) return "";
                StringBuilder newStrng = new();
                StringBuilder chunk = new();
                foreach (var item in strng)
                {
                    chunk.Append(item);
                    if (chunk.Length.Equals(sz))
                    {
                        int sumCubes = CalcSumCubes(chunk);
                        if ((sumCubes % 2).Equals(0))
                        {
                            ReverseString(ref chunk);
                        }
                        else
                        {
                            RotateString(ref chunk);
                        }
                        newStrng.Append(chunk);
                        chunk.Clear();
                    }
                }
                return newStrng.ToString();
            }
            public static int CalcSumCubes(StringBuilder number)
            {
                int sum = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    sum += Convert.ToInt32(Math.Pow(Convert.ToInt32(number[i]), 3));
                }
                return sum;
            }
            public static void ReverseString(ref StringBuilder str)
            {
                for (int index = 0; index < str.Length / 2; index++)
                {
                    var tmpChar = str[index];
                    str[index] = str[str.Length - 1 - index];
                    str[str.Length - 1 - index] = tmpChar;
                }
            }
            public static void RotateString(ref StringBuilder str)
            {
                var first = str[0];
                for (int i = 0; i < str.Length - 1; i++)
                {
                    str[i] = str[i + 1];
                }
                str[str.Length - 1] = first;
            }
        }

        public class WeightSort
        {
            public static string orderWeight(string strng)
            {
                if (strng.Length.Equals(0)) return String.Empty;
                List<string> weights = new();
                StringBuilder weight = new();
                foreach (var item in strng)
                {
                    if (!item.Equals(' '))
                    {
                        weight.Append(item);
                    }
                    else if (!weight.Length.Equals(0))
                    {
                        weights.Add(weight.ToString());
                        weight.Clear();
                    }
                }
                weights.Sort
                ((weight1, weight2) =>
                    {
                        return CalcSumDigits(weight1).CompareTo(CalcSumDigits(weight2));
                    }
                );
                StringBuilder newStrng = new();
                foreach (var item in weights)
                {
                    newStrng.Append(item);
                    newStrng.Append(' ');
                }
                newStrng.Remove(newStrng.Length - 1, 1);
                return newStrng.ToString();
            }

            public static int CalcSumDigits(string number)
            {
                int sum = 0;
                foreach (var item in number)
                {
                    sum += Convert.ToInt32(item);
                }
                return sum;
            }
        }

    }
}
