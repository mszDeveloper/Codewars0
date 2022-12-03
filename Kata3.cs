using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars0
{
    class Kata3
    {

        class NextPalindrom
        {
        //https://www.codewars.com/kata/56a6ce697c05fb4667000029/train/csharp
            static int GetLeftSubNumber(int val)
            {
                string valStr = val.ToString();
                int digitCount = valStr.Length;
                string valStrLeft = valStr.Substring(0, digitCount / 2);
                return int.Parse(valStrLeft);
            }
            static int GetReverseRightSubNumber(int val)
            {
                string valStr = val.ToString();
                int digitCount = valStr.Length;
                string valStrRight;
                if ((digitCount % 2).Equals(0))
                {
                    valStrRight = valStr.Substring(digitCount / 2, digitCount / 2);
                }
                else
                {
                    valStrRight = valStr.Substring(digitCount / 2 + 1, digitCount / 2);
                }
                return int.Parse(Reverse(valStrRight));
            }
            static string Reverse(string str)
            {
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            public static int NextPal(int val)
            {
                while (true)
                {
                    val++;
                    if (GetLeftSubNumber(val).Equals(GetReverseRightSubNumber(val)))
                    {
                        return val;
                    }
                }            
            }
            //12
            //123
            //121
            //1234
            //12345        
            /**
             *   
             *  public static int NextPal(int val) {
                for (int i = val + 1; i < int.MaxValue; i++) {
                  var digits = i.ToString().ToCharArray();
                  Array.Reverse(digits);
                  if (i.ToString() == new string(digits)) return i;
                }
             */
        }








    }
}
