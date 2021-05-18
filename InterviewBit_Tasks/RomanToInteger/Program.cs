using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    /// <summary>
    /// Given a string A representing a roman numeral.
    /// Convert A into integer.
    /// A is guaranteed to be within the range from 1 to 3999.
    /// NOTE: Read more details about roman numerals at Roman Numeric System
    /// For Example Input 1: A = "XIV" Output 1:14
    /// Input 2: A = "XX" Output 2:  20
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.RomanToInt("XX"));
        }
    }
    public class Solution
    {
        public int RomanToInt(string A)
        {
            var symbols = new Dictionary<char, int>() {
                { 'I', 1},
                { 'V', 5 },
                 { 'X', 10 },
                  { 'L', 50 },
                   { 'C', 100 },
                    { 'D', 500 },
                     { 'M', 1000 }

            };

            var aLen = A.Length - 1;
            symbols.TryGetValue(A[aLen], out var result);
            var prevVal = result;

            for (int i = aLen - 1; i >= 0; i--)
            {
                symbols.TryGetValue(A[i], out var currVal);

                if (currVal < prevVal)
                {
                    result -= currVal;
                }
                else
                {
                    result += currVal;
                }

                prevVal = currVal;
            }

            return result;
        }
    }
}
