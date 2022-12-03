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
                    string valStr = val.ToString();
                    if (valStr.Equals(Reverse(valStr)))
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
