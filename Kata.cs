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
                if (input.Length.Equals(0)) return false;
                if (input.First().Equals(')') || input.Last().Equals('(')) return false;
                bool isParenthesis = false;
                foreach (var item in input)
                {
                    if (item.Equals('(') || item.Equals(')'))
                    {
                        isParenthesis = true;
                        break;
                    }
                }
                if (!isParenthesis) return false;
                /*
                 *              ())(()
                 *              ((()())(()    
                 *              ((()()))()
                 *              (( 
                 *              ((()))
                 *              
                 */
                //var inputTmp = input;

                List<int> indexesForErase = new();
                while (true)
                {
                    bool isOpeningParenthesis = false;
                    int OpeningParenthesisIndex = -1;
                    for (int index = 0; index < input.Length; index++)
                    {
                        if (input[index].Equals('(') && !isOpeningParenthesis)
                        {
                            OpeningParenthesisIndex = index;
                            isOpeningParenthesis = true;
                            continue;
                        }
                        if (input[index].Equals(')') && isOpeningParenthesis)
                        {
                            indexesForErase.Add(OpeningParenthesisIndex);
                            indexesForErase.Add(index);
                            isOpeningParenthesis = false;
                        }
                    }
                    if (indexesForErase.Count.Equals(0))
                    {
                        break;
                    }
                    int countRemovals = 0;
                    foreach (var index in indexesForErase)
                    {
                        input = input.Remove(index - countRemovals, 1);
                        countRemovals++;
                    }
                    indexesForErase.Clear();
                }
                foreach (var item in input)
                {
                    if(item.Equals('(') || item.Equals(')'))
                    {
                        return false;
                    }
                }
                return true;
            }

            public static bool ValidParentheses1(string input)
            {
                if (input.Length < 2) return false;
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
                bool isNotDone = true;
                while (isNotDone)
                {
                    isNotDone = false;
                    for (int index = 0;;)
                    {
                        if (index >= parenthesis.Length) break;
                        if (index.Equals(parenthesis.Length - 1) && parenthesis[index].Equals('(')) return false;
                        if (parenthesis[index].Equals('(') && parenthesis[index + 1].Equals(')'))
                        {
                            isNotDone = true;
                            parenthesis = parenthesis.Remove(index, 2);
                            if (parenthesis.Length.Equals(0)) return true;
                            if (!index.Equals(0)) index--;
                            continue;
                        }
                        index++;
                    }
                }
                return false;
            }

            public static bool ValidParentheses2(string input)
            {
                if (input.Length < 2) return false;
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











    }
}
