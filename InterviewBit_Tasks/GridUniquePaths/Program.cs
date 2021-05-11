using System;

namespace GridUniquePaths
{
    /// <summary>
    /// A robot is located at the top-left corner of an A x B grid .
    /// The robot can only move either down or right at any point in time. 
    /// The robot is trying to reach the bottom-right corner of the grid .
    /// How many possible unique paths are there?
    /// Note: A and B will be such that the resulting answer fits in a 32 bit signed integer.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.uniquePaths(2, 3));
        }
    }
    public class Solution
    {
        public int uniquePaths(int A, int B)
        {
            if (A <= 0 || B <= 0) return 0;
            if (A == 1 || B == 1) return 1;
            return uniquePaths(A - 1, B) + uniquePaths(A, B - 1);

        }
    }
}
