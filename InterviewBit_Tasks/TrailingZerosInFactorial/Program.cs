using System;

namespace TrailingZerosInFactorial
{
    class Program
    {
        /// <summary>
        /// Problem Description
        /// Given an integer A, return the number of trailing zeroes in A!.
        /// Note: Your solution should be in logarithmic time complexity.
        /// **Problem Constraints**  1 <= A <= 10000
        /// Input Format: First and only argumment is integer A.
        /// Example: Input: 5 ; Output: 1
        /// Example: Input: 9247 ; Output: 2307
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.trailingZeroes(9247));
        }
    }

    public class Solution
    {
        public int trailingZeroes(int A)
        {

            var zeroCount = 0;

            if (A <= 4)
            {
                return 0;
            }

            while (A >= 5)
            {
                zeroCount += A / 5;
                A /= 5;
            }
            return zeroCount;
        }
    }
}
