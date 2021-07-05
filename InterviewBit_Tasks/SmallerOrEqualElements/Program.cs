using System;
using System.Collections.Generic;

namespace SmallerOrEqualElements
{
    /// <summary>
    /// Given an sorted array A of size N. Find number of elements which are less than or equal to B.
    /// NOTE: Expected Time Complexity O(log N)
    /// Example Input:  A = [1, 3, 4, 4, 6]  B = 4. Output: 4
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            var A = new List<int> { 1, 2, 5, 5 };
            Console.WriteLine(s.Solve(A, 3));
        }
    }
    public class Solution
    {
        public int Solve(List<int> A, int B)
        {
            var res = 0;

            foreach (var a in A)
            {
                if (a <= B)
                {
                    res++;
                }
                else
                {
                    break;
                }
            }

            return res;
        }
    }
}
