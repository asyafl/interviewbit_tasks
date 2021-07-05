using System;
using System.Collections.Generic;

namespace SortedInsertPosition
{
    /// <summary>
    /// Given a sorted array A and a target value B, return the index if the target is found. 
    /// If not, return the index where it would be if it were inserted in order.
    /// You may assume no duplicates in the array.
    /// Input 1: A = [1, 3, 5, 6]  B = 5. Output: 2
    /// Input 2: A = [ 1, 3, 5, 6 ]  B = 2. Output: 1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var A = new List<int> { 1, 3, 5, 6 };
            Console.WriteLine(s.Solve(A, 7));
        }
    }
    public class Solution
    {
        public int Solve(List<int> A, int B)
        {
            var start = 0;
            var end = A.Count - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (A[mid] == B)
                {
                    return mid;
                }
                else if (B < A[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return end + 1;

        }
    }
}
