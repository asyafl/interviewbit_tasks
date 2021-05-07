using System;

namespace ReverseInteger
{
    /// <summary>
    /// Reverse digits of an integer.
    /// Example1: x = 123,  return 321
    /// Example2: x = -123, return -321
    /// Return 0 if the result overflows and does not fit in a 32 bit signed integer
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.Reverse(-1146467285));
        }
    }
    public class Solution
    {
        public int Reverse(int A)
        {
            string str = A.ToString();
            var res = "";

            if (A < 0)
            {
                res = "-";
                for (int i = str.Length - 1; i > 0; i--)
                {
                    res += str[i];
                }
            }
            else
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    res += str[i];
                }
            }

            if (int.TryParse(res, out var returnVal))
            {
                return returnVal;
            }
            else
            {
                return 0;
            }

        }
    }
}
