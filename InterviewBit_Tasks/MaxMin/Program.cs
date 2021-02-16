using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxMin
{
    /// <summary>
    /// Problem Description
    /// Given an array A of size N.You need to find the sum of Maximum and Minimum element in the given array.
    /// NOTE: You should make minimum number of comparisons.
    /// Problem Constraints
    /// 1 <= N <= 105
    /// -10^9 <= A[i] <= 10^9
    /// Input Format:  First and only argument is an integer array A of size N.
    /// Output Format: Return an integer denoting the sum Maximum and Minimum element in the given array.
    /// Example Input
    /// Input: A = [-2, 1, -4, 5, 3]  Output: 1
    /// Input: A = [1, 3, 4, 1]  Output: 5
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var arr = new int[] { 1, 3, 4, 1 };

            List<int> A = arr.ToList();
            Console.WriteLine(s.Solve(A));
        }
    }
    public class Solution
    {
        public int Solve(List<int> A)
        {
            int count = A.Count;

            var minVal = int.MaxValue;
            var maxVal = int.MinValue;

            for (int i = 0; i < count; i++)
            { 
                if(A[i] > maxVal)
                {
                    maxVal = A[i];
                }
                else if (A[i] < minVal)
                {
                    minVal = A[i];
                }
            }
            return maxVal + minVal;

        }
    }
}
